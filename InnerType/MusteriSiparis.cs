using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriSiparis
    {
        public string SiparisNo { get; set; }

        public Urun[] urunler = new Urun[3];
    }
}
