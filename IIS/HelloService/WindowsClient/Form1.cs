using System;
using System.Windows.Forms;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HelloService.HelloServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = client.GetMessage(textBox1.Text);
        }
    }
}
