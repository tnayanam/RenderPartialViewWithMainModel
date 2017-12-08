using System.Runtime.Serialization;

namespace TestService
{
    [DataContract] // THis is required, if we do not give it we get Serialization exception
    class Student
    {
        [DataMember] // same here, we need this to avoid sedrializatrion exception
        public string SName { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
}
