using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_21022023
{
    internal class Matematik
    {
        //public, private, protected, internal

        public void MenuHazirla()
        {
            Console.Clear();
            Console.WriteLine("Menü");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Seçiminiz:");
        }

        public decimal ToplamaIslemi(decimal sayi1,decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }
        public decimal CikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal fark = sayi1 - sayi2;
            return fark;
        }
        public decimal CarpmaIslemi(decimal sayi1, decimal sayi2)
        {
            return sayi1 * sayi2;
        }

        public decimal BolmeIslemi(decimal sayi1, decimal sayi2)
        {
            return sayi1 / sayi2;
        }

        public void Ekranayaz(decimal sayi1,decimal sayi2,decimal sonuc,string islem)
        {
          Console.WriteLine("{0}{3}{1}={2}",sayi1,sayi2,sonuc,islem);
        }

    }
}
