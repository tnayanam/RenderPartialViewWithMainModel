using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public string GetEmployee()
        {
            return "Hello World";
        }
    }
}


// create a empty class library, delete its auto generated class, then add a wcf service to it and take it formward from there.