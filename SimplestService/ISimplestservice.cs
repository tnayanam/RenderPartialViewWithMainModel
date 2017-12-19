using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimplestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISimplestservice" in both code and config file together.
    [ServiceContract]
    public interface ISimplestservice
    {
        [OperationContract(IsOneWay = true)]
        void DoWork();
    }
}
