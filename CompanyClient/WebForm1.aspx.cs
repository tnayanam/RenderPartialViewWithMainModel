using System;

namespace CompanyClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // below consatructor's pare,meter name is the binding name from web.config file
            CompanyService.CompanyPublicServiceClient client = new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Label1.Text = client.GetPublicInformation();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyConfedentialServiceClient client = new CompanyService.CompanyConfedentialServiceClient("NetTcpBinding_ICompanyConfedentialService");
            Label2.Text = client.GetConfedentialInformation();
        }
    }
}

// Awesome One complete flow done. Kindly note that if you want to test the client, you need to open two different VS solution. You cannot run the Host as well as 
// client in the same instance.
// Also note than RUN VS IN administrator MODE


