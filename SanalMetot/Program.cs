using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri M1 = new Musteri();
            M1.isim = "elif";
            M1.soyisim = "cengiz";
            Console.WriteLine(M1.ToString()); 
            Console.ReadLine();
        }
    }
}
