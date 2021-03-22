using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2] { "ANKARA", "sivas" };
            //cities = new string[3];
            //Console.WriteLine(cities[0]);

            ArrayList cities = new ArrayList();
            cities.Add("ANKARA");
            cities.Add("SİVAS");
            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
            cities.Add("İstanbul");
            Console.WriteLine(cities);
            Console.ReadLine();
        }
    }
}
