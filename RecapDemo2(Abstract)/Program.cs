using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2_Abstract_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            Console.ReadLine();


        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Log()
        {
            Logger.Log();
            Console.WriteLine("LOGGED!");
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }
    }


    class DatabaseLogger:ILogger
    {
        public ILogger Logger { get; set; }
        public void Log()
        {
            Logger.Log();
            Console.WriteLine("LOGGED!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged TO FİLED");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
