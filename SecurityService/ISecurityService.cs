using System.ServiceModel;

namespace SecurityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISecurityService" in both code and config file together.
    [ServiceContract]
    public interface ISecurityService
    {
        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        string None(string message);
        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.Sign)]
        string Sign(string message);
        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
        string SignAndEncrypt(string message);
    }
}
