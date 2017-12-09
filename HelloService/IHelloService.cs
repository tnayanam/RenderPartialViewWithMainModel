using System.ServiceModel;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract] /// this is making this a WCF Service
    public interface IHelloService
    {
        [OperationContract] // this is making sure that this method is avialbale for the clients
        string GetMessage(string name); // this is the service a client can invoke
    }
}
