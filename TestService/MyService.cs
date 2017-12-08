using System;

namespace TestService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "Hello World";
        }

        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public string GetMessage(string Message)
        {
            return "Hello" + Message;
        }

        public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        {
            double avg = M1 + M2 + M3 / 3;
            if (avg < 35)
                return "Fail";
            return "Pass";
        }

        public int[] GetSorted(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}

/*
 * A WCF Service has 3 components: 
 * Create a Service
 * Host a Service
 * Consume the Service
 * Now in this check in we created a basic service and changed the App.Config file accordingly.
 * and we ran it Visual Studio did two things, hosted our service as well as Gave us a clinet which consumed this service
 * On running the app Double clicked on the GetData and then clicked on Invoke to run the consume the service.
 */
