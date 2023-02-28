using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumNedir
{
    public enum cinsiyet
    {
        kadın,erkek
    }
    internal class sanalDatabase
    {
        ArrayList sanalDb= new ArrayList();
        public MusteriSonuc MusteriKayit(Musteri M)
        {
           M.cinsiyet = cinsiyet.kadın;

           int sonuc= sanalDb.Add(M);
         
            if (sonuc == 0)
            {
                return MusteriSonuc.kayitBasarisiz;
            }
            else if (sonuc == 1)
            { 
                return MusteriSonuc.kayitBasarili; 
            }
            else
                return MusteriSonuc.calismaZamaniHatasi;
        }

        public MusteriSonuc MusteriSil(Musteri M)
        {
            sanalDb.Remove(M);
            //işlemler
            return MusteriSonuc.parametreHatasi;
        }
    }
}
