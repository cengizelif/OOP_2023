using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //içiçe nesne kullanımı
            Musteri M1 = new Musteri();
            M1.Id = 1;
            M1.isim = "elif";
            M1.soyisim = "cengiz";
            M1.TCNo = "123456";
            M1.OlusturmaTarihi = DateTime.Now;

            MusteriAdres MA = new MusteriAdres();
            MA.Adres = "kartal";
            MA.Ilce = "kartal";
            MA.AdresTip = "ev";
            MA.Il = "istanbul";

            M1.MusteriAdresleri[0] = MA;
            M1.MusteriAdresleri[1] = new MusteriAdres()
            { Adres = "kadikoy", AdresTip = "is", Il = "istanbul", Ilce = "kadıkoy" };

            Console.WriteLine("İl:");
            string il = Console.ReadLine();
            Console.WriteLine("İl:");
            string ilce = Console.ReadLine();
            Console.WriteLine("İl:");
            string adres = Console.ReadLine();

            M1.MusteriAdresleri[2] = new MusteriAdres()
            {  Adres = adres, AdresTip = "is", Il = il, Ilce = ilce };

            M1.MusteriTelefonlari[0] = new MusteriIletisim() { aktifPasif = true, alankodu = "0555", numara = "1234567", IletisimTip = 100 };

            M1.MusteriTelefonlari[1] = new MusteriIletisim() { aktifPasif = true, alankodu = "0544", numara = "1234567", IletisimTip = 110 };

            //Musteri M2 = new Musteri();

            //Console.WriteLine("İsim:");
            //M2.isim = Console.ReadLine();

            //MusteriAdres MA2 = new MusteriAdres();
            //Console.WriteLine("Adres:");
            //MA2.Adres = Console.ReadLine();
            //Console.WriteLine("Il:");
            //MA2.Il = Console.ReadLine();

            //M2.MusteriAdresleri[0] = MA2;

            M1.MusteriAdresleri[0].MusteriAdresMetot();

            M1.MusteriSiparisleri[0] = new MusteriSiparis()
            {
                SiparisNo = "SIP001"
            };

            M1.MusteriSiparisleri[0].urunler[0] = new Urun()
            {
                Id = 1,
                fiyat = 18.5,
                UrunAdi = "Makarna"
            };

            M1.MusteriSiparisleri[0].urunler[1] = new Urun()
            {
                Id = 2,
                fiyat = 19.5,
                UrunAdi = "süt"
            };

            M1.MusteriSiparisleri[1] = new MusteriSiparis()
            { SiparisNo = "SIP002" };

            M1.MusteriSiparisleri[1].urunler[0] = new Urun()
            {
                Id=3,
                fiyat=80,
                UrunAdi="çay"
            };

        }
    }

}
