using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Ogrenci
    {
        public void OrtalamaHesapla(byte n1,byte n2,byte n3,string adsoyad,int odev=45,int proje=45)
        {
            decimal ortalama = (n1 + n2 + n3+odev) / 4;
            OrtalamaDegerlendir(ortalama,adsoyad);
        }

        private void OrtalamaDegerlendir(decimal ort,string isim)
        {
            if(ort>=45)
            {
                Console.WriteLine("Merhaba {0} Geçtiniz",isim);
            }
            else
            {
                Console.WriteLine("Merhaba {0} Kaldınız",isim);
            }
        }

    }
}
