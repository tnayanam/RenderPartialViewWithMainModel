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
            _number = _number + 1;
            return _number;
        }
    }
}
