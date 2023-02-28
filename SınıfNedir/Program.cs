using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1=new Musteri();
            M1.TcKimlikNo = "123456789";
            M1.isim = "elif";
            M1.soyisim = "cengiz";
            M1.cinsiyet = 002;

            M1.MusteriKontrol();

            M1 = null;

            Musteri M2 = new Musteri("deneme");
            M2.isim = "Büşra";
            M2.TcKimlikNo = "987654321";

            Musteri M3 = new Musteri("tcno", "isim");

            string isim = M2.isim;
            M2 = null;

            Console.ReadLine();
        }
    }
}
