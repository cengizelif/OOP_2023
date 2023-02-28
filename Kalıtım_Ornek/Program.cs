using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            televizyon T1 = new televizyon();
            T1.marka = "Samsung";
            T1.model = "";
            T1.alisfiyati = 1000;
            T1.satisfiyati = 999;
            T1.barkod = "12345";
            T1.UrunEkle(T1);
            T1.mesaj();
            T1.EkranaYaz("televizyon");

            Urun U1 = new Urun();
            U1 = T1;//boxing

            object data = U1;
            data = T1;//boxing

            televizyon T2=new televizyon();
            T2 =(televizyon)U1; //unboxing
            data = T2;//boxing

            T1 =(televizyon)data;//unboxing

            bilgisayar B1 = new bilgisayar();
            B1.marka = "HP";
            B1.alisfiyati = 1000;
            B1.satisfiyati = 999;
            B1.barkod = "12345";
            B1.UrunEkle(B1);
            B1.mesaj();
            B1.EkranaYaz("bilgisayar");
         
      

            data = B1;

            televizyon T3 = new televizyon();
            data = T3;
            T3 =(televizyon)data;
           
            /*baseclass: id,barkod,olusturmatarihi,olusturankullanıcı,silindi
             *urun:marka,model,alısfiyatı,satısfiyatı
             *alısfiyatı<0 olamaz satisfiyatı<alısfiyatı olamaz.
             *bilgisayar:islemci,ram,ekrankartı
             *tv:HDMI,ekranboyutu,smartTV
             *
             *yeniurunekle(bilgisayar)
             *yeniurunekle(tv)
             *
             *bu ürünler sanaldatabase e eklenecek. eklenirken barkod kontolu yapılacak.
             *
             *
             *
             *
             */

        }
    }
}
