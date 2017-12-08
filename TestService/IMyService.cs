using System.ServiceModel;

namespace TestService
{
    [ServiceContract] // here we are telling this interface needs to accessible by the world
    interface IMyService
    {
        [OperationContract] // here we are telling this method needs to be accessible  by the world
        string GetData();
    }
}
