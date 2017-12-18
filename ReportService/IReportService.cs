using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IReportServiceCallBack))]
    public interface IReportService
    {
        [OperationContract(IsOneWay = true)]
        void ProcessReport();
    }

    public interface IReportServiceCallBack
    {
        [OperationContract(IsOneWay = true)]

        void Progress(int PercentageCompleted);
    }
}

// here we are learning about adding duplex pattern in request-reply message (which is by default) service. 
// Here we implemented Duplex Messaging pattern using One Way Operations, here we dont need to worry abotu deadlock and threading 
// Instancing Mode in WCF 
/*
 * There are 3 instancing ways:\
 * When client calls the service then instance gets created of the service
 * Per Call: every call creates a new instance
 * per Session: pre session per instance
 * Single: one instace for the lifetime of the applcation.
 */
