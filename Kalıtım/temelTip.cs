using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    internal class temelTip
    {
        public static int sayac = 1;

        private int _id;
        public int ID {
            get { return _id; }
            private set
            {
                _id = value;
            } 
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }

        public temelTip()
        {
            _id = sayac;
            sayac++;
            //Console.WriteLine("temeltip ctor çalıştı");
            //temeltipMetot();
        }

        protected void temeltipMetot()
        {
            //protected yalnızca kalıtılan sınıftan erişilebilir
            //onun dısında erişilemez
        }

    }
}
