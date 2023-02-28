using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_23022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Müşteri sınıfı içinde 
             * ID,isim,soyisim,email,kullanıcıadi,sifre
             static arraylist olacak = sanal database

            Kapsülleme: kullanıcı adı sanaldatabase de varsa eklemesin, email adres sanaldatabase de varsa eklemesin

            MüşteriEkle() metotu müşteri nesnesinin kullanıcı ve email null değilse sanaldatabase eklesin

             */
            Musteri M1 = new Musteri();
            M1.Email = "cenelif@gmail.com";
            M1.kullanciadi = "cenelif";
            M1.sifre = "1234";
            M1.isim = "elif";
            M1.soyisim = "cengiz";
            M1.ID = 1;
            
            M1.MusteriEkle(M1);

            Musteri M2 = new Musteri();
            M2.Email = "cenelif@gmail.com";
            M2.kullanciadi = "cenelif";
            M2.sifre = "1234";
            M2.isim = "elif";
            M2.soyisim = "cengiz";
            M2.ID = 1;

            M2.MusteriEkle(M2);
          
            Musteri M3 = new Musteri() { ID = 2, isim = "xx", soyisim = "xx", sifre = "xx", Email = "xx", kullanciadi = "xx" };
            M3.MusteriEkle(M3);

            Musteri.EkranaYaz();
        }
    }
}
