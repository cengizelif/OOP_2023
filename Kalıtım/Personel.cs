using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Personel:temelTip
    {
        public DateTime IseBaslamaTarihi { get; set; }
        public DateTime IsdenCikisTarihi { get; set; }
        public int izinGunSayisi { get; set; }

        public Personel()
        {
          //  sayac = 10;
            Console.WriteLine("personel ctor çalıştı");
        }

        public void PersonelMetot()
        {
            Console.WriteLine();
            temeltipMetot();
        }
    }
}
