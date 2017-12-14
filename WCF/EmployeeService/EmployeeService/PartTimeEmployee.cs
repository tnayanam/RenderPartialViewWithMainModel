using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [DataContract]
    class PartTimeEmployee:Employee
    {
        [DataMember]
        public int HourlyPay { get; set; }

        [DataMember]
        public int HoursWorked { get; set; }
    }
}
