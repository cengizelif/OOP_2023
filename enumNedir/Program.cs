using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M = new Musteri();
            M.isim = "elif";
            M.soyisim = "cengiz";
            M.email = "cenelif@gmail.com";

            sanalDatabase sdb=new sanalDatabase();
          
            if(sdb.MusteriKayit(M) == MusteriSonuc.kayitBasarili)
            {
                Console.WriteLine("Kayıt başarılı");
            }

            int no = (int)MusteriSonuc.parametreHatasi;

            if(sdb.MusteriSil(M)== MusteriSonuc.kayitBasarili)
            {
                Console.WriteLine("Kayıt silindi");
            }

            Ogrenci O1 = new Ogrenci();
            O1.OgrenciID = 1;
            O1.OgrenciNo = "315";
            O1.bolum = Alan.yabancidil;



        }
    }
}
