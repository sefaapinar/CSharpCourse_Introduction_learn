using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Computer", "BİLGİSAYAR");
            dictionary.Add("Apple", "Elma");
            Console.WriteLine(dictionary["Computer"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            
            Console.ReadLine();
        }
    }
}
