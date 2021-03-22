using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.Showalert();




            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.Showalert;
            myDelegate();

            Console.ReadLine();
        }
    }



    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void Showalert()
        {
            Console.WriteLine("Be careful!");
        }
    }
}
