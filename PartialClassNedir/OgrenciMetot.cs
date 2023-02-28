using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    internal partial class Ogrenci
    {
        public static void EkranaYaz()
        {
            ogrenciler.ForEach(x => Console.WriteLine("Adı:"+x.ad+" Soyadı:" + x.soyad));         
        }

        public static void KayitEkle(Ogrenci nesne)
        {
           ogrenciler.Add(nesne);
           bool sonuc=ogrenciler.Contains(nesne);
           if(sonuc)
            Console.WriteLine("Kayıt eklendi");
        }

        public static void KayitSil(Ogrenci nesne)
        { 
           bool sonuc=ogrenciler.Remove(nesne);
           if(sonuc)
            Console.WriteLine("Kayıt silindi");
        }
    }
}
