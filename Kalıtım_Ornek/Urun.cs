using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Ornek
{
    internal class Urun:baseClass
    {
        public string marka { get; set; }
        public string model { get; set; }

        private decimal _alisfiyati;
        public decimal alisfiyati { 
            get { return _alisfiyati; } 
            set { 
            if(value<0)
                {
                    Console.WriteLine("Alış fiyatı sıfırdan küçük olamaz.");
                }
            else
                {
                    _alisfiyati = value;
                }
            } 
        }

        private decimal _satisfiyati;
        public decimal satisfiyati {
            get { return _satisfiyati; }
            set
            {
                if (value < _alisfiyati)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz.");
                }
                else
                {
                    _satisfiyati = value;
                }
            }
        }

        public override void mesaj()
        {
            Console.WriteLine("Merhaba Urun");
        }
    }
}
