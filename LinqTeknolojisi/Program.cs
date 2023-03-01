using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    internal class Program
    {
        static bool funcDelegate(Musteri m)
        {
            if (m.isim[0]=='A')
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            sanaldatabase sb = new sanaldatabase();
            List<Musteri> liste=sb.MusteriListesi();
            int adet = 0;
            //Adı A ile başlayan kaç adet müşteri var?
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].isim[0].ToString().ToUpper() == "A")
                   adet++;
            }

            Console.WriteLine("Listede adı A ile başlayan {0} kişi var.",adet);

            Console.WriteLine();
            adet = 0;

            //Linq metotları
            adet = liste.Where(i => i.isim.StartsWith("A")).Count();

            //Linq sorgusu

            var musteriler = from m in liste
                              where m.isim.StartsWith("A")
                              select m;

            int toplamadet = musteriler.Count();

            Console.WriteLine("Listede adı A ile başlayan {0} kişi var.", toplamadet);

            //Müşterilerden isminde B harfi geçenlerin sayısı

            int Badet = liste.Where(i => i.isim.Contains("B")).Count();

            List<Musteri> bliste = liste.Where(i => i.isim.ToUpper().Contains("B") && i.Ulke.ToUpper().Contains("A")).ToList();//ismin içinde b geçenlerin ve ülkesi içinde A geçenlerin listesi

            //Doğum yılı 1990 dan büyük olan ve isminde A geçenleri listeleyin

            var ornek = from m in liste
                        where m.DogumTarihi.Year > 1990 && m.isim.ToUpper().Contains("B")
                        orderby m.isim descending //descending Z-A ya sıralar, ascending A-Z ye sıralar 
                        select m;

            foreach (var item in ornek)
            {
                Console.WriteLine($"İsim: {item.isim} , Doğum Tarihi: {item.DogumTarihi} ");
            }

            var top10 = liste.Take(10);

            List<Musteri> yeniliste = liste.Take(5).ToList();

            int x = 10;
            string data = x.ToString();


            foreach (var item in top10)
            {
                Console.WriteLine(item.isim);
            }


            //foreach (var item in bliste)
            //{
            //    Console.WriteLine($"İsim: {item.isim} , Ülke: {item.Ulke} ");
            //}



            var delegatekullanimi1 = liste.Where(i => i.isim.StartsWith("A"));

            Func<Musteri,bool> FuncDelegate1 = new Func<Musteri, bool>(funcDelegate);

            var delegatekullanimi2 = liste.Where(FuncDelegate1);

            foreach (var item in delegatekullanimi2)
            {
                Console.WriteLine(item.isim);
            }

            var delegatekullanimi3 = liste.Where(delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; });

            Console.ReadLine();

        }


    }
}
