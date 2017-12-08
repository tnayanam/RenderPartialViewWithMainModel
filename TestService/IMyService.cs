using System.Collections.Generic;
using System.ServiceModel;

namespace TestService
{
    [ServiceContract] // here we are telling this interface needs to accessible by the world
    interface IMyService
    {
        [OperationContract] // here we are telling this method needs to be accessible  by the world
        string GetData();

        [OperationContract]
        string GetMessage(string Message);

        [OperationContract]
        string GetResult(Student S);

        [OperationContract]
        int GetMax(int[] arr);

        [OperationContract]
        int[] GetSorted(int[] arr);

        [OperationContract]
        List<Country> GetAllCountries();
    }
}
