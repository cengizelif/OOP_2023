using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    internal class Personel : Musteri,IPersonel
    {
        private string _sicilNo;
        string _tcno;
        public string sicilNo { 
            get { return _sicilNo;  }
            set { _sicilNo = value; } }
        public string TcNo { 
            get { return _tcno; }
            set { _tcno = value; } }

        public int Test1()
        {
            Console.WriteLine("IPersonel Test");
            return 1;
        }

        public void Test()
        {
            Console.WriteLine("Personel Test");
        }
        public string Test2()
        {
            Console.WriteLine("Personel Test2");
            return "";
        }

        public void Test(int sayi)
        {
            throw new NotImplementedException();
        }
    }
}
