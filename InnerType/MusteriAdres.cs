using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriAdres
    {
        public string AdresTip { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public void MusteriAdresMetot()
        {
            Console.WriteLine("Müşteri Adres Metotu");
        }

        public MusteriAdres()
        {
            Console.WriteLine("MüşteriAdres ctor çalıştı");
        }
    }
}
