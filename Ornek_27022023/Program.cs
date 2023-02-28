using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_27022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel("elif", "cengiz",DateTime.Parse("01.01.2023") ,Bolum.bilgi_islem);
             P1.Bilgiyaz();

            Personel P2 = new Personel();
            P2.ad = "";
            P2.soyad = "";
            P2.bolum = Bolum.muhasebe;
            P2.DogumTarihi = Convert.ToDateTime("01.01.2000 13:24:00");
            P2.Bilgiyaz();

            Personel P3 = new Personel() { ad = "", soyad = "", bolum = Bolum.bilgi_islem, DogumTarihi = DateTime.Parse("01.01.2022") };
            P3.Bilgiyaz();

            Yonetici y1 = new Yonetici();
            y1.ad = "";
            y1.soyad = "";
            y1.bolum = Bolum.satınalma;
            y1.DogumTarihi = DateTime.Parse("01.01.2022");
            y1.personelSayisi = 20;
            y1.Bilgiyaz();

            Yonetici y2 = new Yonetici("","",Bolum.muhasebe,DateTime.Parse("01.01.2022"),25);
            y2.Bilgiyaz();
        }
    }
}
