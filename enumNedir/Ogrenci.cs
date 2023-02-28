using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumNedir
{
    public enum Alan
    {
        sözel,sayısal,esitagirlik,yabancidil
    }
    internal class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string OgrenciNo { get; set; }
        public Alan bolum { get; set; }

    }
}
