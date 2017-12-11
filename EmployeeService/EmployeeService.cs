using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            // Now we need to fetch a employee from database
            // so here we will write one ado.net code to connect to the database and execute the Stored proicedure that we created in DB to fetch the employee
            Employee employee = null;
            string conStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //string conStr = @"data source =.\MSSQLSERVER01; initial catalog = SAMPLE; integrated security = True";
            // made the connection classwith the connection string
            SqlConnection con = new SqlConnection(conStr);
            //now generating the compelte query along with connection made above
            SqlCommand cmd = new SqlCommand("spGetEmployee", con);
            // now we need to tell that this command is a Stored Procedure and NOT A NORMAL QUERY
            cmd.CommandType = CommandType.StoredProcedure;
            // adding one paremeter isntance
            SqlParameter parameterId = new SqlParameter();
            // now set the paremeter value with the ID of the Employee
            parameterId.Value = id;
            parameterId.ParameterName = "@Id";
            // now added paremeter too in the cmd. So now cmd is comeplte and it has everything now.
            cmd.Parameters.Add(parameterId);
            //open the db connection
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if ((EmployeeType)dr["EmployeeType"] == EmployeeType.FullTimeEmployee)
                {
                    employee = new FullTimeEmployee
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        Gender = dr["Gender"].ToString(),
                        DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]),
                        Type = EmployeeType.FullTimeEmployee,
                        AnnualSalary = Convert.ToInt32(dr["AnnualSalary"])
                    };
                }
                else
                {
                    employee = new PartTimeEmployee
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        Gender = dr["Gender"].ToString(),
                        DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]),
                        HourlyPay = Convert.ToInt32(dr["HourlyPay"]),
                        HoursWorked = Convert.ToInt32(dr["HoursWorked"]),
                        Type = EmployeeType.PartTimeEmployee
                    };
                }
            }

            dr.Close();
            con.Close();
            return employee;
        }

        public void SaveEmployee(Employee employee)
        {
            string conStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(conStr);
            //now generating the compelte query along with connection made above
            SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
            // now we need to tell that this command is a Stored Procedure and NOT A NORMAL QUERY
            cmd.CommandType = CommandType.StoredProcedure;
            // adding one paremeter isntance
            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = employee.Id
            };
            cmd.Parameters.Add(parameterId);
            SqlParameter parameterName = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = employee.Name
            };
            cmd.Parameters.Add(parameterName);
            SqlParameter parameterGender = new SqlParameter()
            {
                ParameterName = "@Gender",
                Value = employee.Gender
            };
            cmd.Parameters.Add(parameterGender);
            SqlParameter parameterDateOfBirth = new SqlParameter()
            {
                ParameterName = "@DateOfBirth",
                Value = employee.DateOfBirth
            };
            cmd.Parameters.Add(parameterDateOfBirth);

            SqlParameter parameterEmployeeType = new SqlParameter()
            {
                ParameterName = "@EmployeeType",
                Value = employee.Type
            };
            cmd.Parameters.Add(parameterEmployeeType);

            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                SqlParameter parameterAnnualSalary = new SqlParameter()
                {
                    ParameterName = "@AnnualSalary",
                    Value = ((FullTimeEmployee)employee).AnnualSalary
                };
                cmd.Parameters.Add(parameterAnnualSalary);
            }
            else
            {
                SqlParameter parameterHourlyPay = new SqlParameter()
                {
                    ParameterName = "@HourlyPay",
                    Value = ((PartTimeEmployee)employee).HourlyPay
                };
                SqlParameter parameterHoursWorked = new SqlParameter()
                {
                    ParameterName = "@HoursWorked",
                    Value = ((PartTimeEmployee)employee).HoursWorked
                };
                cmd.Parameters.Add(parameterHourlyPay);
                cmd.Parameters.Add(parameterHoursWorked);
            }
            // now added paremeter too in the cmd. So now cmd is comeplte and it has everything now.
            //open the db connection
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

/*
 * Stored procedure that was added for the Employee CLient to call upon
 * Create procedure spGetEmployee
@Id int
as
Begin
 Select Id, Name, Gender, DateOfBirth
 from tblEmployee 
 where Id = @Id
End

Create procedure spSaveEmployee
@Id int,
@Name nvarchar(50),
@Gender nvarchar(50),
@DateOfBirth DateTime
as
Begin
 Insert into tblEmployee
 values (@Id, @Name, @Gender, @DateOfBirth)
End
 */
