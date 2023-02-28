using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            temelTip T1 = new temelTip();
            // T1.temeltipMetot();           
            //T1.ID = 50;

            Personel P1 = new Personel() { Ad="dfsfs",Soyad="dfdsfd", TCNo="dfsdfd"};
           // P1.temeltipMetot();
            P1.PersonelMetot();
            // P1.ID = 1; //bu atamaya izin vermesin otomatik sıra numarası verilsin
            
            Console.WriteLine(P1.ID);

            Egitmen E1 = new Egitmen();
           // E1.temeltipMetot();
            E1.PersonelMetot();
            E1.EgitmenMEtot();
            Console.WriteLine(E1.ID);

            Ogrenci O1 = new Ogrenci();
            // O1.temeltipMetot();
            //O1.ID = 2;
            Console.WriteLine(O1.ID);

            Console.ReadLine();
        }
    }
}
