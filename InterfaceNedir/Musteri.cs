using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    internal class Musteri : Imusteri
    {
        private int _id;
        string _isim;
        string _soyisim;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string isim { 
            get { return _isim; }
            set { _isim = value; } }
        public string soyisim { 
            get { return _soyisim; }
            set { _soyisim = value; } }

        public int kayitDuzenle(int Id, string isim, string soyisim)
        {
            Console.WriteLine("Kayıt düzenlendi");
            return 1;
        }

        public int kayitSil(int Id)
        {
            Console.WriteLine("Kayıt silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayıt eklendi.");
            return 1;
        }
    }
}
