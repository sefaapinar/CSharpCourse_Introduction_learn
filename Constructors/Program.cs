using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Sefa Pınar");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
           employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSometing2();
            

   



            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {
        
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items!!!" , _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }


    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
        interface Ilogger
        {
            void log();
        }
    class DatabaseLogger : Ilogger
    {
        
        public void log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : Ilogger
    {

        public void log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private Ilogger _logger;
        public EmployeeManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.log();
            Console.WriteLine("Added!");
        }
       
    }


    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;

        }

        public void Message()
        {
            Console.WriteLine("Sefa", _entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("VERİ TABANINA EKLENDİ");
            Message();
        }
    }


    static class Teacher
    {
        public static int Number { get; set; }

    }     
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("VALIDATION İS DONE");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSometing2()
        {
            Console.WriteLine("done2");
        }
    }
    
}
