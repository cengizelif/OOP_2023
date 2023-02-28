using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_21022023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Matematik m = new Matematik();
          
            YenidenIslem:
            m.MenuHazirla();
            string secim = Console.ReadLine();
            decimal sayi1 = 0,sayi2=0;

            if (secim=="1" || secim=="2" || secim=="3" || secim=="4")
            {
                Console.WriteLine("1.Sayı:");
                sayi1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("2.Sayı:");
                sayi2 = decimal.Parse(Console.ReadLine());
            }
    
            decimal sonuc = 0;
            switch (secim)
            {
                case "1":
                    sonuc=m.ToplamaIslemi(sayi1, sayi2);
                    m.Ekranayaz(sayi1, sayi2, sonuc, "+");
                    break;
                case "2":
                    sonuc=m.CikarmaIslemi(sayi1, sayi2);
                    m.Ekranayaz(sayi1, sayi2, sonuc, "-");
                    break;
                case "3":
                    sonuc=m.CarpmaIslemi(sayi1, sayi2);
                    m.Ekranayaz(sayi1, sayi2, sonuc, "*");
                    break;
                case "4":
                    sonuc=m.BolmeIslemi(sayi1, sayi2);
                    m.Ekranayaz(sayi1, sayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.Lütfen yeniden deneyin");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslem;
            }

            Console.WriteLine("Yeniden işlem yapmak ister misiniz?");
            string cevap = Console.ReadLine();
            if(cevap.ToUpper()=="E")
            {
                goto YenidenIslem;
            }
    

            //[Erişim belirleyicisi][Geri dönüş tipi][Metotun adı](Parametreler)
           // Console.Clear();

           // Selamla();        

           // string isim = "elif";

           // Mesaj(isim);

           // Mesaj("elif");

           // Toplam(2,3,5);

           // int fark = 0;
           // fark=Fark(8, 4);
           // Console.WriteLine(fark);
           // Console.WriteLine(Fark(15,9));

           //string gelendeger=EkranaYaz("Merhaba");
           // Console.WriteLine(EkranaYaz("Merhaba"));
           // Console.ReadLine();


            
        }

        static string EkranaYaz(string mesaj)
        {
            mesaj = "deneme";
            return mesaj;
        }

        static int Fark(int s1,int s2)
        {
            int fark = s1 - s2;
            return fark;
        }
        static void Toplam(int s1,int s2,int s3)
        {
            int toplam=s1+ s2;
            Console.WriteLine(toplam);
        }
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
            //işlemler
        }
        static void Mesaj(string mesaj)
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine(mesaj);
            //işlemler
        }
    }
}
