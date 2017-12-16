using System.ServiceModel;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    // IF NOT IN CONFIG THEN MAKE CHANGES HERE
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CalculatorService : ICalculatorService
    {
        public int Divide(int Numerator, int Denominator)
        {
            return Numerator / Denominator;
        }
    }
}

/*
 * Now here we are getting "System.ServiceModel.FaultException" exception. Basically, when the service generates the divide by zero .net exception
 * it gets desaerialized into a SOAP Fault exception class and sent to the client. So actual exception is not hsown on the client
 * for security purpose. If you want actual exception then you should make changes in the config file or the code file as mentioned. 
 */
