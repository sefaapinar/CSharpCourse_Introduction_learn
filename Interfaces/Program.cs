using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //    PersonManager manager = new PersonManager();
            //    manager.Add(new Customer { Id = 1, FirstName = "Sefa", LastName = "Pınar" });

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal();
            new OracleCustomerDal();


        }






    }
           
         

       

    interface Iperson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }

    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
