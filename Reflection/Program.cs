using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(3, 1));

             var istance =Activator.CreateInstance(type, 6, 7);

            MethodInfo methodInfo = istance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Methodadı : {0}", info.Name);
                foreach (var VARIABLE in info.GetParameters)
                {

                }
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _Sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _Sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2(int sayi1, int sayi2)
        {
            return _sayi1 + _Sayi2;
        }
        public int Carp2(int sayi1, int sayi2)
        {
            return _sayi1 * _Sayi2;
        }

       
    }

}
