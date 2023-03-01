using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{
    internal class Program
    {
        delegate void MatematikselIslemler(int sayi1, int sayi2);
        delegate void EkranaYaz(string isim, string soyisim);

        static void Test(string s1,string s2)
        {
            Console.WriteLine(s1+" "+s2);
        }

        static void Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }

        static void Cıkar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }

        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }

        static void Main(string[] args)
        {
            //Topla(1, 1);
            //Cıkar(2, 2);
            //Carp(2, 3);

            MatematikselIslemler M1 = new MatematikselIslemler(Topla);

            M1 += Carp;
            M1 += Cıkar;

            M1.Invoke(2, 4);

            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cıkar;
            M1.Invoke(3, 4);


            EkranaYaz E1 = new EkranaYaz(Test);

            E1.Invoke("deneme", "deneme");

            EkranaYaz E2=new EkranaYaz(delegate(string isim,string soyisim) 
            {
                Console.WriteLine(isim+" "+soyisim);
            });

            E2 += Test;
            E2.Invoke("elif", "cengiz");

            EkranaYaz E3 = (isim, soyisim) => { Console.WriteLine(isim + " " + soyisim); };

            E3 += Test;
            E3.Invoke("xx", "zz");

            Console.ReadLine();
        }
    }
}
