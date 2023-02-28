using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method overloading (metotların aşırı yüklenmesi)
            Topla(1, 2);
            Topla("elif", "cengiz");
            Topla(3m, 4m);
            Topla(1m, 4m, 5m);


            EkranaYaz(Topla(5, 4));
            EkranaYaz(Topla(5, 4,Topla(1,2)));

            LocalFunctionKullanimi(1, 2);

            Console.WriteLine();           
        }

        static void LocalFunctionKullanimi(int sayi1,int sayi2)
        {
            int Topla(int s1,int s2)
            {
                return s1 + s2;
            }

            Console.WriteLine(Topla(sayi1,sayi2));
        }


        static void EkranaYaz(int sayi)
        {
            Console.WriteLine(sayi);
        }

        static int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static int Topla(int sayi1, int sayi2,int sayi3)
        {
            int toplam = sayi1 + sayi2+sayi3;
            return toplam;
        }
        static void Topla(string ad,string soyad)
        {
            Console.WriteLine(ad+" "+soyad);
        }
        static void Topla(decimal s1, decimal s2)
        {
            Console.WriteLine(s1+s2);
        }
        static void Topla(decimal s1, decimal s2,decimal s3)
        {
            Console.WriteLine(s1 + s2+s3);
        }

        static decimal Topla(decimal s1, decimal s2,int s3)
        {
            decimal toplam=s1 + s2+s3;
            return toplam;
        }
    }
}
