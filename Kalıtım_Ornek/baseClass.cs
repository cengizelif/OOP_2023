using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Ornek
{
    internal class baseClass
    {
        //id,barkod,olusturmatarihi,olusturankullanıcı,silindi

        static int sayac = 1;
        private int _id;
        public int Id
        {
            get { return _id; }
            private set { }
        }

        public baseClass()
        {
            _id = sayac;
            sayac++;
        }

        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                if (BarkodKontrol(value))
                {
                    Console.WriteLine("Barkod daha önce eklenmiştir.");
                    _barkod = String.Empty;
                }
                else
                {
                    _barkod = value;
                }
            }
        }
        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }
        public bool silindi { get; set; }

        static ArrayList sanaldatabase = new ArrayList();
        public void UrunEkle(Urun u)
        {
            if (!string.IsNullOrEmpty(u.barkod))
            {
                if (BarkodKontrol(u.barkod))
                {
                    Console.WriteLine("Bu ürün daha önce eklenmiş");
                }
                else
                {
                    sanaldatabase.Add(u);
                }
            }
            else
            {
                Console.WriteLine("Barkod boş olamaz.");
            }

        }

        public bool BarkodKontrol(string barkod)
        {
            bool kontrol = false;

            if (sanaldatabase.Count > 0 && !string.IsNullOrEmpty(barkod))
            {
                for (int i = 0; i < sanaldatabase.Count; i++)
                {
                    Urun u = (Urun)sanaldatabase[i];
                    if (u.barkod == barkod)
                    {
                        kontrol = true;
                        break;
                    }
                }

            }


            return kontrol;
        }

        public virtual void mesaj()
        {
            Console.WriteLine("Merhaba baseclass");
        }

        public virtual void EkranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
