using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractNedir
{
    internal class Kare:Sekil
    {
        public decimal kenar { get; set; }

        public override void AlanHesapla()
        {
            alan = kenar * kenar;
            Console.WriteLine("Alan:" + alan);
        }

        public override void CevreHesapla()
        {
            cevre = 4 * kenar;
            Console.WriteLine("Çevre:" + cevre);
        }
    }
}
