using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Musteri
    {
        //TCNo set: girilen değer 11 hane olmalıdır.Girilen değerler sayısal veri olmak zorunda,
        //get: TCNo ilk 3 hanesi gösterilsin

      
        private string _tcno;
        public string TCNo {
            get {
                if (_tcno == null)
                    return "";
                else
                   return _tcno.Substring(0,3)+"********";                
            }
            set 
            {              
                if (value.Length==11)
                {
                    bool kontrol = true;
                    for (int i = 0; i < 11; i++)
                    {
                        kontrol = char.IsNumber(value[i]);
                        if(kontrol==false)
                        {
                            Console.WriteLine("Girilen değer sayısal olmak zorunda");
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        _tcno = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik No 11 hane olmalıdır.");
                }
                
                
            }        
        }


        private int _id;
        private static int sayac = 1;

        public Musteri()
        {
            _id = sayac;
            sayac++;
        }
        public int ID { 
            get {
                return
                   // IDUret(); 
                   _id;                
            } 
            private set { _id = value; } 
        }

        public int IDUret()
        {
            Random rnd = new Random();
            _id = rnd.Next(1,100);
            return _id;
        }

        public string isim { get; set; }
        private string _soyisim;
        public string soyisim {
            get { 
                return _soyisim;
            }
            set { 
                _soyisim = value;
                emailadres = isim + "." + _soyisim + "@gmail.com";
            } 
        }

        private string emailadres;//Field
      
        public string Emailadres {  //property
            get { 
                return emailadres; 
            }
            private set
            {
                emailadres = value; 
            }
        }

        private string adres;
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

    }
}
