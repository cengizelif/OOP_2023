using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    internal class Musteri<T>
    {
        public T Id { get; set; }
        public T musterino { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
    }
}
