using System;

namespace HelloWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label1.Text = client.GetMessage(TextBox1.Text);
        }
    }
}


/*
 * What just happened in nutshell
 * 1. We created a simple class Library (dll) it will represent the WCF Service.
 * Then we created a WCF Service project and added referece to the dll. Because we are creating the host
 * and host should know what are the stuffs it needs to host.
 * We changed the app.config file of the Host. we needed to do so because client application will use
 * those information to connect to the service.
 * we added end point details of the service, and also we added WSDL stuff all in App.config of the Hosting SAervice
 * Now we created a Client which will consume the service. so we created a basic empty application but there
 * we need to tell the client which services it needs to refer to. So go to references of the client applicaiton
 * and then click on Add Swervice Reference. there you need to specify the WSDL URL Locatrion
 * by doing this the client will generate a proxy class for you which will help in connecting to the service
 * And now in the main clinet program crate object of that proxy class and call whatever methodf you want to call.
 */
