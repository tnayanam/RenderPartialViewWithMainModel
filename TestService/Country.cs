﻿using System.Runtime.Serialization;

namespace TestService
{
    [DataContract]
    class Country
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string CountryName { get; set; }
    }
}
