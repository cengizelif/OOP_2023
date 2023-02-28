using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    internal interface Imusteri
    {
       int ID { get; set; }
       string isim { get; set; }  
       string soyisim { get; set; }

        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int Id,string isim,string soyisim);
        int kayitSil(int Id);
      


    }
}
