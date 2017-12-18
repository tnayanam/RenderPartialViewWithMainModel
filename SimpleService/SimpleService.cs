using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession) ]
    public class SimpleService : ISimpleService
    {
        private int _number;
        public int IncrementNumber()
        {
            System.Console.WriteLine("Session id " + OperationContext.Current.SessionId); // tells about the SessionId
            _number = _number + 1;
            return _number;
        }
    }
}

/*
 * In here we have created a session but the time out is set to 10 second. so after 10 second we will start getting an exception. if client tries to communicate aagain.  
 */
