using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_27022023
{
    public enum Bolum
    {
        muhasebe,ik,satınalma,bilgi_islem
    }
    internal class Personel
    {
        static int sayac = 1;
        private int _id;
        public int ID { 
            get { return _id; } 
           private set { _id = sayac; }
        }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Bolum bolum { get; set; }
        public Personel()
        {
          _id = sayac;
            sayac++;
        }
        public Personel(string ad,string soyad,DateTime tarih,Bolum bolum)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.DogumTarihi = tarih;
            this.bolum = bolum;
            this.ID = sayac;
            sayac++;

        }

        public void Bilgiyaz()
        {
            int yas = DateTime.Now.Year - DogumTarihi.Year;
            Console.WriteLine(ID);
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(bolum);
            Console.WriteLine(yas);
        }
    }
}
