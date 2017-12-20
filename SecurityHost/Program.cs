using System;
using System.ServiceModel;

namespace SecurityHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
            ServiceHost(typeof(SecurityService.SecurityService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}

/*
 * Security of WCF depends on two things
 * - The WCF Message itself (ENcryption and all of that)
 * - The medium of message transfer (Http, TCp etc)
 * 
 * - By default NetTCPBinding provides Transport Layer Security where as WSHttpBinding provides Message Layer Security
 * 
 * The TCP provides trasnport seciurty by Implementing  Transport Layer Security (TLS) - (Medium of Message Transfer Security) is provided by OS itself
 * HTTP provides Transport security by SSL
 * 
 * Pros And Cons of Transport Layer And MEssage Security
 * Transport Layer----
 * Improved Performance
 * It does not required community party to understand the inside XML Details as it just secures the channel
 * Streaming is possible
 * 
 * Disadvantage of Mesage laye secrity
 * XML Bloating - Performance
 * Message Streamming not possible
 * 
 * 
 * 
 * Now as far as this example is concerned we used wshttpbinsing. and then we right clicked on the app.config of host to edit wcf configuration
 * an then enables logging from there. now after one succesfful clinet call we opened the log fine and foiund out thatr XM messaege body is all encrypted and signed (which is the defaut behaviour of wsHttpBinding).
 * 
 */
