using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal class Ogrenci
    {
        //static olmayan class static öğeler barındırabilir.
        //static öğelere nesne örneği alınmadan erişilebilir.
        //static classlarda yalnızca statik öğeler bulunabilir.

        public static string ad;
        public string soyad;
        public static string domain;

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci ctor çalıştı");
        }

        static Ogrenci()
        {
            domain = "abc.com";
            Console.WriteLine("Static ctor çalıştı.");
        }
        public void Test1()
        {
            Console.WriteLine("Test 1");
            Test2();
          
        }
        public static void Test2()
        {
            Test3();   
            //static olan öğelere erişilebilir.
            Console.WriteLine("Test 2");
        }
        public static void Test3()
        {
          
            //static olan öğelere erişilebilir.
            Console.WriteLine("Test 3");
        }
    }
}
