using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    class FullTimeEmployee : Employee
    {
        [DataMember]
        public int AnnualSalary { get; set; }
    }
}
