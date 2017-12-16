using System;
using System.Runtime.Serialization;

namespace EmployeeService
{
    [DataContract]
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public class Employee : IExtensibleDataObject
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        //[DataMember]
        //public string Gender { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public EmployeeType Type { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}


// Here suppose we removed a property, and now new clients will know that proeprty is not there.
// also with old clients also everything wil work fine as extra data is simply ignored by the server.
// but what If we want to reutnr whateevr the extra data client is sendinf. For that we make above changes.
// So old clients will still receive the old data.