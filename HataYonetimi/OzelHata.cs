using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    internal class OzelHata:Exception
    {
        public OzelHata()
        {
            Console.WriteLine("Özel hata");
        }
    }
}
