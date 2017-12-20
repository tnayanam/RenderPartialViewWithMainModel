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
           MessageBox.Show( client.None(textBox1.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Encrypted_Click(object sender, EventArgs e)
        {
            //SecurityService.SecurityServiceClient client = new SecurityService.SecurityServiceClient();
            //MessageBox.Show(client.SignAndEncrypt(textBox1.Text));

        }

        private void btn_Signed_Click(object sender, EventArgs e)
        {
            //SecurityService.SecurityServiceClient client = new SecurityService.SecurityServiceClient();
            //MessageBox.Show(client.Sign(textBox1.Text));
        }
    }
}
