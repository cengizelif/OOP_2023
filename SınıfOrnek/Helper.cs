using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal static class Helper
    {
        static Helper()
        {
            //ctor
            Console.WriteLine("static ctor çalıştı.");
        }
        public static void test()
        {
            Console.WriteLine("test");
        }
    }
}
