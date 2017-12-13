using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {
        public Student GetStudent()
        {
            Student std = new Student
            {
                Id = 1,
                Name = "Tanuj"
            };
            return std;
        }
    }
}
