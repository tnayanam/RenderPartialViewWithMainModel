using System;

namespace EmployeeService
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}


/*
 * Initial Set up done was in SSMS created a database named sample and then created a table names tblEMployee and created two sprocs
 * Now creating this Class Library (dll) meaning service 
 */
