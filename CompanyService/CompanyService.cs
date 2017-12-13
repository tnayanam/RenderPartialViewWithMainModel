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
 */

