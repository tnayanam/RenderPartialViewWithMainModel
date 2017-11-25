using System;
using System.Threading;


// Logic
/*
 * 1. A birthdate of a person does not change so it should be set just once
 * 2. the age is calculated based on birthdate so it should not have a setter
 
     
     */




namespace ConsoleApplication1
{
    public enum Postal
    {
        FedEx = 0,
        USPS = 1,
        UPS = 2
    }

    public class Stopwatch
    {
        private DateTime _StartTime;
        private DateTime _StopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning) throw new Exception();
            this._StartTime = DateTime.Now;
            _isRunning = true;
        }
        public void Stop()
        {
            if (!_isRunning) throw new Exception();
            this._StopTime = DateTime.Now;
            _isRunning = false;
        }
        public TimeSpan Span()
        {
            return this._StopTime - this._StartTime;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(1000);
            sw.Stop();
            Console.WriteLine(sw.Span());

        }
    }
}
