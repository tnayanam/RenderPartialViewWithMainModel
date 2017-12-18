using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace PerSessionClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient();
            try
            {

           MessageBox.Show( client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
            }
            catch (System.ServiceModel.CommunicationException)
            {
                if(client.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    client = new SimpleService.SimpleServiceClient();
                    MessageBox.Show(client.IncrementNumber().ToString());
                    MessageBox.Show(client.IncrementNumber().ToString());
                    MessageBox.Show(client.IncrementNumber().ToString());
                    MessageBox.Show(client.IncrementNumber().ToString());
                }
            }

         
        }
    }
}
