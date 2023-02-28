using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string TCNo { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public Musteri()
        {
            Console.WriteLine("Müşteri ctor çalıştı");
        }

        //InnerType gerektiren alanlar
        public MusteriAdres[] MusteriAdresleri = new MusteriAdres[3];

        public MusteriIletisim[] MusteriTelefonlari = new MusteriIletisim[3];

        public MusteriSiparis[] MusteriSiparisleri = new MusteriSiparis[10];

        //Müşterinin siparişleri olacak
        //siparişno ve ürünler
        //siparişin ürünleri olacak.
        //ürün adı ve fiyatı


    }
}
