using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Ornek
{
    internal class televizyon:Urun
    {
        public string HDMI { get; set; }
        public string ekranboyutu { get; set; }
        public string smartTV { get; set; }

        public override void mesaj()
        {
            Console.WriteLine("Merhaba televizyon");
        }

        public override void EkranaYaz(string data)
        {
            Console.WriteLine("ürün:"+data);
        }
   
    }
}
