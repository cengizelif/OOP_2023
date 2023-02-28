using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
           // M1.ID = 1;
            M1.isim = "elif";
            M1.soyisim = "cengiz";

           // M1.Emailadres = "cenelif@gmail.com";//set çalıştı
            M1.Adres = "deneme";

            yenidenTC:
            string tcno = Console.ReadLine();
            M1.TCNo = tcno;

            if (M1.TCNo == "")
            {
                goto yenidenTC; 
            }

           
            Console.WriteLine(M1.TCNo);

            Console.WriteLine(M1.ID);
            Console.WriteLine(M1.Adres);
            Console.WriteLine(M1.Emailadres);//get çalıştı
            Console.WriteLine(M1.ID);

            Musteri M2 = new Musteri();

            Console.WriteLine(M2.ID);

            Console.ReadLine();
            //Field değer ataması yapılamasın ama değer okunabilsin.
            //Field değer ataması yapılsın ama değer okunamasın
            //Field değer ataması yapılsın ama ilk 4 hanesi okunsun
            //Field değer atama ve okuma işlemleri bazı kontroller ya da işlemlerden geçirilerek yapılsın.

        }
    }
}
