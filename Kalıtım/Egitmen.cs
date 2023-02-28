using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Egitmen : Personel
    {
        public string Brans { get; set; }

        public Egitmen()
        { 
            Console.WriteLine("Eğitmen ctor çalıştı");
        }

        public void EgitmenMEtot()
        {
            temeltipMetot();
        }
    }
}
