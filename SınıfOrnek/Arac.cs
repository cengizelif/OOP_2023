using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal class Arac
    {
        //marka,model,modelyil,km,yakıttipi,vitestipi,alisfiyati,
        //satisfiyati,maxindirimtutari

        //FiyatAta(495000)
        //BilgileriGoruntule 

        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal km;
        public string YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal indirimTutari;
        public decimal Fiyat;

        public Arac()
        {

        }
        public Arac(string marka,string model)
        {
            Marka= marka;
            Model = model;
        }

        public void FiyatAta(decimal fiyat)
        {
            decimal tutar = SatisFiyat - indirimTutari;
            if(fiyat>tutar && fiyat<=SatisFiyat)
            {
                Fiyat = fiyat;
            }
            else
            {
                Console.WriteLine("Geçersiz fiyat");
                Fiyat = tutar;
            }
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("{0} {1} \n Km:{2} Yıl:{3} \n Fiyat:{4} ",Marka,Model,km,ModelYil,Fiyat);
        }

    }
}
