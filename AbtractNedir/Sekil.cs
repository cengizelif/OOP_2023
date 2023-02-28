using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractNedir
{
    internal abstract class Sekil
    {
        public string SekilAd { get; set; }
        public decimal alan { get; set; }
        public decimal cevre { get; set; }  
        public void SekilAdYaz(string isim)
        {
            Console.WriteLine(isim);
        }
        public abstract void AlanHesapla();//abstract metotun gövdesi olmaz. yalnızca imzası olur. Kalıtılan sınıf bu metotu implement etmek zorundadır.
        public abstract void CevreHesapla();

    }
}
