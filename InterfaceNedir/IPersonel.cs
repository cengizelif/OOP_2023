using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    internal interface IPersonel
    {
        string sicilNo { get; set; }
        string TcNo { get; set; }

        void Test(int sayi);
        int Test1();
        string Test2();
    }
}
