using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac araba = new Arac();

            //Console.WriteLine("Marka:");
            //string marka = Console.ReadLine();

            araba.Marka = "Opel";
            araba.Model = "Astra";
            araba.km = 135000;
            araba.ModelYil = 2010;
            araba.AlisFiyat = 500000;
            araba.SatisFiyat = 600000;
            araba.indirimTutari = 5000;
            araba.FiyatAta(490000);
            araba.BilgileriGoruntule();

            Arac araba2 = new Arac("Opel", "Astra");
            araba2.km = 20000;
            araba2.ModelYil = 2010;
            araba2.AlisFiyat = 500000;
            araba2.SatisFiyat = 600000;
            araba2.indirimTutari = 5000;
            araba2.FiyatAta(599000);
            araba2.BilgileriGoruntule();


            //Bisiklet  kiralama
            //Bisiklet sınıfı Marka Model VitesSayisi Renk
            //Kullanıcı sınıfı Ad Soyad TCNo Telefon
            //Kiralama sınıfı Kullanıcı Bisiklet sure OdenecekTutar
            // baslangiczamanı bitiszamani

            Kullanici kullanici = new Kullanici();
            kullanici.Ad = "elif";
            kullanici.Soyad = "cengiz";
            kullanici.TCNo = "123456789";
            kullanici.Telefon = "123456789";

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.Marka = "bisan";
            bisiklet.Model = "xwe5";
            bisiklet.VitesSayisi = "24";
            bisiklet.Renk = "mavi";
           // float fiyat =float.Parse(Console.ReadLine());
            bisiklet.fiyat = 1.3f;
           

            Kiralama kiralama = new Kiralama();
 
            kiralama.kullanici = kullanici;
            kiralama.bisiklet = bisiklet;
           

            kiralama.KiralamaBaslat();
            System.Threading.Thread.Sleep(5000);
            kiralama.KiralamaBitir();

            Console.Clear();

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Test1();
            Ogrenci.Test2();//static olan metotlara nesne örneği alınmadan erişilir.

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Test1();

            Helper.test();
            Helper.test();
            Helper.test();
           
            Console.ReadLine();

        }
    }
}
