using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci classı içinde öğrencinin 3 notunun ortalamasını hesaplayan metot
            //ortalama>=45 ise geçtiniz değilse kaldınız mesajı veren başka bir metot olacak
            //Console.WriteLine("Örencinin Adı Soyadı:");
            //string adsoyad = Console.ReadLine();

            //Console.Write("1.Not:");
            //byte not1 = byte.Parse(Console.ReadLine());
            //Console.Write("2.Not:");
            //byte not2 = byte.Parse(Console.ReadLine());
            //Console.Write("3.Not:");
            //byte not3 = byte.Parse(Console.ReadLine());

            //Ogrenci ogr = new Ogrenci();
            //ogr.OrtalamaHesapla(not1, not2, not3, adsoyad);


            //Girilen 3 sayıdan en büyüğünü bulan metotu  yazın (Matematik class)

            //Console.WriteLine("1.sayı:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayı:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("3.sayı:");
            //int sayi3 = int.Parse(Console.ReadLine());

            Matematik m = new Matematik();
            //int sonuc = m.EnBuyukSayi(sayi1, sayi2, sayi3);
            //Console.WriteLine("En büyük sayı:{0}",sonuc);

            //Girilen sayının asal olup olmadığını bulan metotu yazalım

            Console.WriteLine("Sayı:");
            int sayi = int.Parse(Console.ReadLine());

           //bool sonuc=m.Asalmi(sayi);

            if(m.Asalmi(sayi))
            {
                Console.WriteLine("Sayı asaldır");
            }
            else
            {
                Console.WriteLine("Sayı asal değil.");
            }

            //girilen sayının faktoriyelini bulup geriye sonucu döndüren metot


            Console.WriteLine("Faktoriyel:"+m.Faktoriyel(sayi));

            //10 elemanlı bir diziye random sayı atılacak. Bu dizi bir metota gönderilip ekrana yazdırılacak.
            int[] dizi = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(1, 100);
            }

            //m.DiziyiYaz(dizi);

            ////Bu dizideki tek sayıları başka diziye atıp geriye dönüren bir metot
            //Console.WriteLine("Tek sayılar:");
            //m.DiziyiYaz(m.TekSayilar(dizi));

            //m.Toplam(100,"+",5,7,3,8,9,15,19,25);
            //m.Toplam(5,"", 7, 3, 8);
            //m.Toplam(3,"", 6);

            int rakam=0;
            degerAta(ref rakam);

            Console.WriteLine(rakam);
            Console.ReadLine();

        }
    
        static void degerAta(ref int gelendeger)
        {
            gelendeger = 10;

        }
    
    }

}
