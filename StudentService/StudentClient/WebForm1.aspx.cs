using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("BasicHttpBinding_IStudentService");
            StudentService.Student std = null;
            std = new StudentService.College
            {
                CollegeName = "sdfgfd",
                Id = 2,
                Id1 = 4,
                Name = "test",
                NickName = "holiday"
            };
        }
    }
}