using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci() { ad="elif",soyad="cengiz", Id=1,OgrNo="12"};

            //öğrenci listesine kayıt ekleme ve silme işlemini oluşturduğumuz metotlar ile yapın.             

            Ogrenci.KayitEkle(ogr1);

            Ogrenci ogr2 = new Ogrenci() { ad = "elif", soyad = "cengiz", Id = 1, OgrNo = "12" };
            Ogrenci.KayitEkle(ogr2);

            Ogrenci.EkranaYaz();

            Ogrenci.KayitSil(ogr2);

        }
    }
}
