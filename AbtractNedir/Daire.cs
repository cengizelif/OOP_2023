using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractNedir
{
    internal class Daire:Sekil
    {
        public decimal yaricap { get; set; }
    
        public override void AlanHesapla()
        {
            alan = 3.14m * yaricap * yaricap;
            Console.WriteLine("Alan:"+alan);
        }

        public override void CevreHesapla()
        {
            cevre = 2 * 3 * yaricap;
            Console.WriteLine("Çevre:"+cevre);
        }

        public void EkranaYaz()
        {
            SekilAd = "daire";
            SekilAdYaz(SekilAd);
        }
    }
}
