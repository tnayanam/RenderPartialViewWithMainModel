using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesClient
{
    public partial class Form1 : Form
    {
        SimplesService.SimplesServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SimplesService.SimplesServiceClient();
        }

        private void btnGetEvenNumbers_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnGetOddNumbers_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            listBoxForEven.DataSource = null;
            listBoxForOdd.DataSource = null;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             e.Result = client.GetEvenNumber();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBoxForEven.DataSource = (int[])e.Result;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = client.GetOddNumber();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBoxForOdd.DataSource = (int[])e.Result;
        }
    }
}


/*
 * Very Impportant Note Here:
 * So, when a client make a call to WCF Service then client can communicate in three ways
 * 1. One Way: Client sends the message and forgets about it. Does not wait for service to respond and process next line is client code.
 * 2. Request-Reply: In this case Client sends the message and waits for the Sercice to send the Respionce back. Till that time all the processing is stopped
 * 3. Duplex: In this case Client sends the message and waits for the server but Server still inteactts with clients via CALLBACKS
 * DEFAULT is OneWay: Important Point: This is done as Operation Contract Level .
 * 
 * Above was related to just messaging/communication. Now below we will discuss about Servicebehavipour meaning the entire WCF serice as a whole
 * Now when even client communicates with the Service an instance of Servcice is created and that instace can be of three type
 * 1. Per Call: Every call makes a new instance
 * 2. per Session: Every session instacen will be same as long as sessino is not expitred. So same client making 2 consecutive calls will use same instance
 * 3. Single: In this case there will be just one instance of the service and it will be shared among all the clinetns across the life tme of the applactinon.
 * By DEFAULT: per SESSION
 * 
 * Now there is one more thing concurrent call. That means different threads will try to create instance of the service.
 * that is of 3 types:
 * 1. single
 * 2. Reentrant
 * 3. Multiple
 * 
 * Now one more thing is there, not every binding supports all of the above mentioned configurations.
 * 
 * This current scenario in this check in /service is of
 * 1. Its by default one way that menas client needs to wait for the response
 * But we have created two separate thread, so each thread will wait.
 * T1, T2 both are created and they both can call the service. as they are on separate thread. Even though they both will wait independenlty for the service to respond as we 
 * have applied Request-Reply.
 * Now when T1 goes it creates one instance and when t2 goes it creates another instance, why becasue it is Per call. So both are running.But one server side the concurrency mode is set to single still both have differnt instance of the server so its basicaly not concurrent in coding sense. and also the binding is set to basic http which does not supprt sessions( anyways we are using per call not session as the instance context mode)
 * Anywyas here we have a positive throughpuit. Watch this video for proper understanding https://www.youtube.com/watch?v=Ls9-nxYr2EA&list=PL6n9fhu94yhVxEyaRMaMN_-qnDdNVGsL1&index=43
 * Note that we still acheievd here concurrent procssing b/w T1 and T2. only becasue both were on different threads and having different instance of the service.
 * So they were teated as different client altogether.
 * 
 * 
 * 
 * 
 */
