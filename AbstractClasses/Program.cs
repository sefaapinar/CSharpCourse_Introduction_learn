using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Deleted();
            database.Add();

            Database database2 = new SqlServer();
            database2.Deleted();
            database2.Add();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Deleted();




    }

    class SqlServer : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class Oracle : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }
}
