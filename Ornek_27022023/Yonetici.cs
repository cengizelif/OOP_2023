using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_27022023
{
    internal class Yonetici:Personel
    {
        public int personelSayisi { get; set; }

        public void Bilgiyaz()
        {
            base.Bilgiyaz();
            Console.WriteLine(personelSayisi);
        }

        public Yonetici()
        {

        }

        public Yonetici(string ad,string soyad,Bolum bolum,DateTime tarih,int _personelsayisi):base(ad,soyad,tarih,bolum)
        {
            //this.ad = ad;
            //this.soyad = soyad;
            //this.bolum = bolum;
            //DogumTarihi = tarih;
           this.personelSayisi = _personelsayisi;
        }
    }
}
