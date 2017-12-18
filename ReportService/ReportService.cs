using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in both code and config file together.
    // below line of code is needed becasue if its not ther then Deadlock will occue. Because client will wait for the service to finsih its operation but in the meantime the service is replying
    //with percent compelted and want to contact the client with percent of reposrt processed update.
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                OperationContext.Current.GetCallbackChannel<IReportServiceCallBack>().Progress(i);
            }
        }
    }
}
/*
 * If we do not implement the Duplex Request Reply pattern then client needs to wait in RequestReply Pattern untill the processing is complete. And if its One-Way pattern then we cannot give status update frequestnly to
 * the client as progress bar. so we use the duplex pattern
 */
