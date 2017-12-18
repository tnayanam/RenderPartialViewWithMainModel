using System.ServiceModel;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract(IsOneWay = true)]
        string GetMessage(string name);
        // above and below has same behavbiour
        //[OperationContract]
        //string GetMessage(string name);
    }
}

// there are three wayys by which client and service interact
/*
 * 1. Request Reply (default)
 * 2. One Way
 * 3. Duplex
 * 
 * If we do not put anything then its always request reply that means the clinet will wait for the service to processs once the service
 * responds then only client processing will proceed further
 * even if return tyoe is void then also the client will proceed when sercie has finished its processing
 * 
 * 
*/
