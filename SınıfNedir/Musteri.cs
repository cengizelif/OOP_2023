using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfNedir
{
    internal class Musteri
    {
       public string TcKimlikNo;
       public string isim;
       public string soyisim;
       public int cinsiyet;//001 002

        public Musteri()  //yapıcı metot
        {
            Console.WriteLine("Yapıcı metot çalıştı");
        }

        ~Musteri() //yıkıcı metot
        {
            Console.WriteLine("Yıkıcı metot çalıştı");
        }

        public Musteri(string Tcno)  //yapıcı metot
        {
            TcKimlikNo = Tcno;
        }

        public Musteri(string Tcno,string _isim)  //yapıcı metot
        {
            this.isim = _isim;
            TcKimlikNo=Tcno;    
        }

        public bool MusteriKontrol()
        {
           bool sonuc=DatabaseKontrol(TcKimlikNo);
            return sonuc;
        }

        private bool DatabaseKontrol(string tcno)
        {
            //database bağlantısı sağlanıp databaseden kotrol yapılır
            return true;
        }
    }
}
