using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessage(string message)
        {
            return "Hello " + message;
        }
    }
}


/*
 * ISSUE IF YOU RUN INTO IIS HOSTING
 * https://stackoverflow.com/questions/47914186/wcf-hosting-on-iis-throwing-exception-dont-have-permission-and-http-error-404/47914543?noredirect=1#comment82799042_47914543
 * 
 * 
 */
