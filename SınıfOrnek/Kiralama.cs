using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal class Kiralama
    {
        public int ID;
        public float Sure;
        public float OdenecekTutar;
        public Kullanici kullanici;
        public Bisiklet bisiklet;
        public DateTime baslangicZamani;
        public DateTime bitisZamani;

        public void KiralamaBaslat()
        {
            baslangicZamani = DateTime.Now;
        }
        public void KiralamaBitir()
        {
            bitisZamani = DateTime.Now;
            UcretHesapla();
        }

        private void UcretHesapla()
        {
            TimeSpan zaman = bitisZamani - baslangicZamani;

            Sure = zaman.Seconds;
            OdenecekTutar = Sure * bisiklet.fiyat;
            EkrandaGoster();
        }

        private void EkrandaGoster()
        {
            Console.WriteLine("Sayın {0} {1} kullanım süreniz: {2} sn. ödenecek tutar: {3} TL ",kullanici.Ad,kullanici.Soyad,Sure,OdenecekTutar);
        }
    }
}
