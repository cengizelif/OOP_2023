using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sekil s1 = new Sekil(); abstract class örneklenemez.

            Kare k = new Kare();
            k.kenar = 10;
            k.SekilAdYaz("kare");
            k.AlanHesapla();
            k.CevreHesapla();
          
        }
    }
}
