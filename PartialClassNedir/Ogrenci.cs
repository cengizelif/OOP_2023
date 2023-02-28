using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    internal partial class Ogrenci
    {
        public int Id { get; set; }
        public string OgrNo { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

       static List<Ogrenci> ogrenciler = new List<Ogrenci>();
    }
}
