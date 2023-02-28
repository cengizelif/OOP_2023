using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal sealed class Ogrenci:temelTip
    {
        public string Bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci ctor çalıştı");
        }

        public void OgrenciMetot()
        {
            temeltipMetot();
        }
    }
}
