using System.ServiceModel;
namespace SecurityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SecurityService" in both code and config file together.
    public class SecurityService : ISecurityService
    {

        public string None(string message)
        {
            System.Console.WriteLine(ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated.ToString());
            System.Console.WriteLine(ServiceSecurityContext.Current.PrimaryIdentity.Name);
            System.Console.WriteLine(ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType);
            return "Hello " + message;
        }



        // output

        /*
         * lenovo
         * Tanuj
         * NTLM
         */
        //public string Sign(string message)
        //{
        //    return "Hello " + message;
        //}


        //public string SignAndEncrypt(string message)
        //{
        //    return "Hello " + message;
        //}
    }

}
