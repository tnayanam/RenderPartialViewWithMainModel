namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}

/*//How did we create this service
 * first created a class library (dll)
 * then in the same project added one WCF Service
 * 
 */

