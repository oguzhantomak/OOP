using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    class FirstClass
    {
        public int Id;
        public string Ad;
        public string SoyAd;

        public int Kilo;
        public int Boy;

        //public int Yas;
        private int _yas;
        public int Yas {
            get
            {
                return _yas;
            }
            set
            {
                if (value<18 && value>55)
                {
                    _yas = value;
                }
                else
                {
                    _yas = 0;
                }
            }
        }

        //public void Set(int yas)
        //{
        //    if (yas < 18 && yas > 55)
        //    {
        //        _yas = 0;
        //    }
        //    else
        //    {
        //        _yas = yas;
        //    }
        //}
        //public int Get()
        //{
        //    return _yas;
        //}

    }
}
