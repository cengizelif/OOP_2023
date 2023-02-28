using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    internal class kullanici
    {
        public int Id { get; set; }
        public string kullaniciAdi { get; set; }
        public string email { get; set; }
        public string sifre { get; set; }

        public static void EkranaYaz(List<kullanici>  liste)
        {
            foreach (kullanici item in liste)
            {
                Console.WriteLine(item.email);
            }
        }
    }
}
