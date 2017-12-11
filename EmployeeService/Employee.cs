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

/*
 * Ok What are KnownTypes attribute and when to use them:"
 * Known types are bassically used when we have inheritance in our Serive Models
 * Actuall when WSDL document gets generated based on the Model of Serivce class it only looks for the Base Model ex : EMployee
 * Because of that when client tries to get employees which are instance of derived class it the Serialized dfoes not know how to
 * serialize it. Actually client has no idea about existence of the Derived classes as W/o knowntyupe attribute the WSDL that gets generated
 * has no idea of derived class hence WCF clinet cant understand our deserialize the resule that is getting returned from the service
 * when we use known type then client understand it and then able to desrialzer the deroived class accordinly.
 * 
 * When ever you create a WCF Service always run the base address that you have added in app.congif class (in my case it is added in hosting console applicaiton)
 * bottom line: always run the base class to knoew about the WSDL document that client wil use.
 * If it does not open properly then that means we might have missed the datacontract or datamember attribute. TO get that information
 * we can use  <serviceDebug includeExceptionDetailInFaults="true"/> in the behaviuours tag. this wil throw the exception when we try to open
 * the WSDL service.
 * Kindly note that the WCF sertcviec might run sucessfully but still we wil ahve issue with the WSDL. so always run the WSDL and amke sure its fine.
 * 
 * When ever you make changes inb Service, then go to Client and right clike on the WCF Service ands click on update service reference
 * 

 */
