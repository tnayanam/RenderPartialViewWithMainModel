namespace TestService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "Hello World";
        }
    }
}

/*
 * A WCF Service has 3 components: 
 * Create a Service
 * Host a Service
 * Consume the Service
 * Now in this check in we created a basic service and changed the App.Config file accordingly.
 * and we ran it Visual Studio did two things, hosted our service as well as Gave us a clinet which consumed this service
 * On running the app Double clicked on the GetData and then clicked on Invoke to run the consume the service.
 */
