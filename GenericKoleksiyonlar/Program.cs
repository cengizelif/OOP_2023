using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add("deneme");

            List<string> isimler = new List<string>();
            isimler.Add("elif");
            isimler.Add("büşra");

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(5);

            int[] data = new int[2];
            data[0] = 4;
            data[1] = 10;

            //1.yol
            for (int i = 0; i < 2; i++)
            {
                sayilar.Add(data[i]);
            }
            //2.yol
            sayilar.AddRange(data);
            sayilar.Add(12);
            sayilar.Add(13);
            sayilar.Add(20);

            sayilar.Remove(20);
            sayilar.RemoveAll(i => i > 10);//belirtilen koşula uygun değerleri siler
            sayilar.RemoveAt(2);//2.indexdeki değeri siler

            int capacity = sayilar.Capacity;
            int count = sayilar.Count;

            sayilar.TrimExcess();//capacity ve count eşitlenir

            //1.yol
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //2.yol
            sayilar.ForEach(i => Console.WriteLine(i));

            int deger = sayilar[4];
            sayilar[4] = 15;
            sayilar.Insert(5, 100);//5.indexe 100 yazar diğerlerini öteler


            bool sonuc = sayilar.Any();//içinde değer var mı kontrolu yapar

            sonuc = sayilar.Any(i => i > 5);//koşulu sağlayan değer varmı
            sonuc = sayilar.Contains(100);//içeriyormu


            sayilar.Reverse();//listeyi ters çevirir.
            sayilar.Sort();//A-Z ye küçükten büyüğe sıralar.
            int max = sayilar.Max(); //listedki en büyük değeri verir.
            int min = sayilar.Min();//listeki en küçük değeri verir.
            int toplam = sayilar.Sum();//listedeki değerleri toplar.
            sayilar.Clear();

            List<kullanici> kullanicilar = new List<kullanici>();

            kullanici k1 = new kullanici();
            k1.Id = 1;
            k1.kullaniciAdi = "cengizelif";
            k1.email = "cenelif@gmail.com";
            k1.sifre = "12345";

            kullanici k2 = new kullanici() { Id = 2, email = "deneme", sifre = "deneme", kullaniciAdi = "deneme" };

            kullanicilar.Add(k1);
            kullanicilar.Add(k2);
            kullanicilar.Add(
                new kullanici()
                {
                    Id = 3,
                    email = "deneme",
                    sifre = "deneme",
                    kullaniciAdi = "deneme"
                });

            //1.yol
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                Console.WriteLine(kullanicilar[i].kullaniciAdi+" " + kullanicilar[i].email);
            }
            Console.WriteLine();

            kullanici yenikullanici = new kullanici();

            //2.yol
            kullanici.EkranaYaz(kullanicilar);
            
            //3.yol
            kullanicilar.ForEach(i => Console.WriteLine(i.kullaniciAdi));


            Musteri<int> m1 = new Musteri<int>();
            m1.Id = 1;
            m1.musterino = 2;
            m1.isim = "";
            m1.soyisim = "";

            GenericClass<kullanici> g1 = new GenericClass<kullanici>();

            Console.ReadLine();
        }
    }
}
