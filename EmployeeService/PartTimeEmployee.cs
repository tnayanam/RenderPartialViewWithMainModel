using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    class PartTimeEmployee : Employee
    {
        [DataMember]
        public int HourlyPay { get; set; }

        [DataMember]
        public int HoursWorked { get; set; }
    }
}
