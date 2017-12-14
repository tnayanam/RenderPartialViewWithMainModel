namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfedentialService
    {
        public string GetConfedentialInformation()
        {
            return "Confedential Information Returned availabel over TCP behind the company firewall";

        }

        public string GetPublicInformation()
        {
            return "Public Information Returned available over http";
        }
    }
}

// Kindly note that as we created wcf client we had to right click on its referenec and all a service reference and add the endpoint of the WSDL so that proxy class can
// be created by client to consume the WCF Service.

// How to allow the Clients to access property of inherited classes and not just base class.
/*
 * 1. [KnownTypes] on Base class : But this option is global, so all services and contracts are going to know about it, as long as their base class is same. ex: Employee
 * 2. [ServiceKnowType] on the Interface of the service itself. if we do this then this derived classes are respected only in that ServiceContract only.
 * Now if we have another service where we want this knowntypes then we again will have to add [ServieKnownType] there
 * exam[le
 *  [ServiceContract]
 *  [ServiceKnownType(typeof(FullTimeEmployee))]
 *  [ServiceKnownType(typeof(PartTimeEmployee))]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
 * 
 * 3. Now suppose we want more granualarity and we want to expose the derived classes to only one of the operation contract then we can apply the [ServiceKnownType] to a particular
 * method
 *  [OperationContract]
 *  [ServiceKnownType(typeof(PartTimeEmployee))]
 *  [ServiceKnownType(typeof(FullTimeEmployee))]
 *  Employee GetEmployee(int id);
 *  4. We can add the knowntypes in config file also: details not needed
 *  
 * How to Enable Tracing: Client Side:
 * 
 * 1. Right Click on Client's who is consuming the service "Web.Config file"
 * 2. There click on Edit WCF Configuartion
 * 3. Now click on Diagnostics and then switch on "Log Auto Flush", "Enable Message Login", "Enable Tracing"
 * 4. Expand the Diagnostics folder, click on Message Logging and the Set LogEntireMessage to True
 * 5. Now when you run WCF Service and the client in the client folder you will find some .svclog dobule click and open it. and then you can click on the messages in the left side and then click on the
 * message that apper on the body. Then at the bottom you wil see the XML message tag. Click there and you will see the Soap Interactions
 * 
 * 
 * 
 * Difference between MessageContract and DataContract:
 * 
 * If we want to change SOAP Header and Body and the name of Response Object in SOAP, we can use MessageContract, MessageHeader and MessageBodyMember attribute. SOAP MessageContract
 * allows us to add custom information in the SOAP Header
 * More like User Credentails or LicenseKeys in the header o invoke the servicelll
 * 
 * SKIPPED THE PRACTICAL IMPLEMENTATION OF MESSAGE CONTRACT, LEFT IT FOR LATER :-|
 * 
 */

