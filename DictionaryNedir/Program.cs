using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add(1, "bir");
            h1.Add(2, "bir");
            //h1.Add(2, "iki");
            h1.Add("iki", "iki");

            Dictionary<int, string> sozluk = new Dictionary<int, string>();
           
            sozluk.Add(1, "bir");
            sozluk.Add(2, "iki");
            sozluk.Add(4, "iki");
            sozluk.Add(30, "iki");

            string deger = sozluk[30];
            sozluk.Remove(30);
            sozluk[4] = "dört";
            bool sonuc= sozluk.ContainsKey(30);
            sonuc= sozluk.ContainsValue("iki");

          
            foreach (KeyValuePair<int,string> item in sozluk)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            SortedList s1 = new SortedList();
            s1.Add(5, "bes");
            s1.Add(2, "iki");
            //s1.Add("", "");

            SortedList<int, string> s2 = new SortedList<int, string>();

            s2.Add(5, "bes");
            s2.Add(2, "iki");

            //Örnek: Girilen kelimedeki her harfden kaç adet olduğunu ekrana yazalım.

            Console.WriteLine("Kelime:");
            string kelime = Console.ReadLine();

            Dictionary<string, int> harfler = new Dictionary<string, int>();

            for (int i = 0; i < kelime.Length; i++)
            {
           
                if(harfler.ContainsKey(kelime[i].ToString()))
                {
                    harfler[kelime[i].ToString()]++;
                }
                else
                {
                    harfler.Add(kelime[i].ToString(), 1);
                }             
                
            }

            foreach (var item in harfler)
            {
                Console.WriteLine("{0} harfi {1} adet",item.Key,item.Value);
            }

            Console.ReadLine();
        }
    }
}
