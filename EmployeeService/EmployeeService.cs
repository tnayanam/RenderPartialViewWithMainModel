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
            Employee employee = new Employee();
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
            // now added paremeter too in the cmd. So now cmd is comeplte and it has everything now.
            cmd.Parameters.Add(parameterId);
            //open the db connection
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                employee.Id = Convert.ToInt32(dr["Id"]);
                employee.Name = dr["Name"].ToString();
                employee.Gender = dr["Gender"].ToString();
                employee.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
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
            // now added paremeter too in the cmd. So now cmd is comeplte and it has everything now.
            //open the db connection
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
