using System;
using System.Windows.Forms;

namespace SecurityClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            SecurityService.SecurityServiceClient client = new SecurityService.SecurityServiceClient();
           MessageBox.Show( client.DoWork(textBox1.Text));
        }
    }
}
