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