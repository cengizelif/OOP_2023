using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Matematik
    {
        public int EnBuyukSayi(int s1,int s2,int s3)
        {         
            if(s1>s2 && s1>s3)
            {
                return s1;
            }
            else if(s2>s3)
            {
                return s2;
            }
            else
            {
                return s3;
            }
       
        }

        public bool Asalmi(int sayi)
        {
            //bool asal = true;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
     
             return true;
        }

        public int Faktoriyel(int sayi)
        {
            int faktoriyel = 1;

            for (int i = 2; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }

        public void DiziyiYaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]!=0)
                  Console.WriteLine(dizi[i]);
            }
        }

        public int[] TekSayilar(int[] dizi)
        {
            int[] tekdizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]%2!=0)
                {
                    tekdizi[i] = dizi[i];
                }
            }

            return tekdizi;
        }

        public void Toplam(int x,string islem,params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam:"+toplam);
        }

    }
}
