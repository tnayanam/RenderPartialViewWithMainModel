using System.ServiceModel;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompanyService" in both code and config file together.
    [ServiceContract]
    public interface ICompanyPublicService
    {
        [OperationContract]
        string GetPublicInformation();
    }

    [ServiceContract]
    public interface ICompanyConfedentialService
    {
        [OperationContract]
        string GetConfedentialInformation();
    }
}

// Here we have multiple service contracts
