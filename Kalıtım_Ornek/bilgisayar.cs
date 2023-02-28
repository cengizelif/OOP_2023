
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Ornek
{
    internal class bilgisayar:Urun
    {
        public string islemci { get; set; }
        public string Ram { get; set; }
        public string ekrankarti { get; set; }

        public override void EkranaYaz(string data)
        {
            Console.WriteLine("ürün:" + data);
        }
    }
}
