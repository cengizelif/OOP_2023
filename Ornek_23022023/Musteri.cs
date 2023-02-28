using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_23022023
{
    internal class Musteri
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        private string email;
        public string Email { 
            get { return email; } 
            set { 
                if(EmailKontrol(value))
                {
                    Console.WriteLine("Bu email sistemde kayıtlı");
                    email = string.Empty;
                }
                else
                {
                    email = value;
                }
            } 
        }


        private string _kullaniciadi;
        public string kullanciadi {
            get { return _kullaniciadi; }
            set {
               if(kullaniciAdiKontrol(value))
                {
                    Console.WriteLine("Bu kullanıcı adı daha önce kullanılmıştır.");
                    _kullaniciadi = string.Empty;
                }
               else
                {
                   _kullaniciadi = value;
                }
                
            } 
        
        }
        public string sifre { get; set; }

        public static ArrayList database = new ArrayList();

        private bool kullaniciAdiKontrol(string kulAd)
        { 
            bool kontrol = false;

            for (int i = 0; i < database.Count; i++)
            {
               Musteri temp = (Musteri)database[i];

               if(temp.kullanciadi==kulAd)
               {
                    kontrol = true;
                    break;
               }
            }

            //foreach (Musteri item in database)
            //{
            //    if (item.kullanciadi == kulAd)
            //    {
            //        kontrol = true;
            //    }
            //}

            return kontrol;
        }


        private bool EmailKontrol(string email)
        {
            bool kontrol = false;         

            foreach (Musteri item in database)
            {
                if (item.email == email)
                {
                    kontrol = true;
                }
            }
            return kontrol;
        }

        public void MusteriEkle(Musteri M)
        {
            if(M!=null && !string.IsNullOrEmpty(M.kullanciadi) && !string.IsNullOrEmpty(M.email))
            {
               database.Add(M);
            }  
            else
            {
                Console.WriteLine("Database kayıt edilemedi.");
            }
        }

        public static void EkranaYaz()
        {
            foreach (Musteri item in database)
            {
                Console.WriteLine(item.kullanciadi);
                Console.WriteLine(item.email);
            }

            //for (int i = 0; i < database.Count; i++)
            //{
            //    Musteri temp = (Musteri)database[i];
            //    Console.WriteLine(temp.isim);
            //    Console.WriteLine(temp.soyisim);
            //}
        }
    }
}
