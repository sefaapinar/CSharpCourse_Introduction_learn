using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class product
    {

    
    }
    interface Product
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Deleted(Product product);
        void Update(Product product);
    }
    
    class Customer
    {

    }
    interface IProductDal:IRepository<Customer>
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer product);
        void Deleted(Customer product);
        void Update(Customer product);
    }


    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Deleted(T entity);
        void Update(T entity);

    }

    class ProductDal : IProductDal
    {
        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public void Deleted(Customer product)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}
