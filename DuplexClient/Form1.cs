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

namespace DuplexClient
{
    // below line of code is needed becasue if its not ther then Deadlock will occue. Because client will wait for the service to finsih its operation but in the meantime the service is replying
    //with percent compelted and want to contact the client with percent of reposrt processed update.
    public partial class Form1 : Form, ReportService.IReportServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessReport_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ReportService.ReportServiceClient client = new ReportService.ReportServiceClient(instanceContext);
            client.ProcessReport();
        }

        public void Progress(int PercentageCompleted)
        {
            //TextBox.CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = PercentageCompleted.ToString() + " % Completed.";
        }
    }
}

/*
 * Point to be noted here:
 * Here we implemented the Duplex Messaging pattern with Request-Reply Operation. So bascially here when we see the prpgress bar changing from 1 to 100% we think that client is not stuck which ideally it should
 * because its request reply and client can only proceed once the operation of the Service is compelted. So even though the percent is changing in the UI Winform the Client is stuck. If you try to change the position of
 * winform drap to other place it will not change, because the procss is not compelted 100% and service has not replied back yet 
 */
