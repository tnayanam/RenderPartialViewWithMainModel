using System;
using System.Runtime.Serialization;

namespace EmployeeService
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public EmployeeType Type { get; set; }
    }
}

/*
 * By default all the public properties are serialized but the private proerpties are not serialized, in Employee class all its property will be
 * serialized as they are public
 * However we can also use [Serializable] attribute to serialize but thne we don't have any control n what to serialize r not. everything gets
 * serialized. alll properties privwte or public
 * 
 * If we out [DataContract] attirubte on the class ex: employee then we have full control on what we want to get serialized. All those property
 * whish will have [DataMember] will only get serialized. 
 * 
 */
