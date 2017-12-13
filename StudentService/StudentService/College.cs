using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
    [DataContract]
    public class College:Student
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CollegeName { get; set; }
    }
}
