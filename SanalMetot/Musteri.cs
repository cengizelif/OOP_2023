using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetot
{
    internal class Musteri
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
