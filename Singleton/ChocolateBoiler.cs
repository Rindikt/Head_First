using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool _empty;
        private bool _boilad;

        private static ChocolateBoiler _chocolateBoiler;
        private ChocolateBoiler()
        {
            _empty = true;
            _boilad = false;
        }

        public static ChocolateBoiler GetClass()
        {
            if (_chocolateBoiler == null)
            {
                ChocolateBoiler chocolateBoiler = new ChocolateBoiler();
            }
            return _chocolateBoiler;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boilad = false;
                //заполнение нагревателя молочно-шоколадной смесью
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiliad())
            {
                //слить нагретое молоко
                _empty = true;
            }

        }

        public void Boil()
        {
            if (!IsEmpty()&& !IsBoiliad())
            {
                //довести содержимое до кипения
                _boilad = true;
            }
        }



        public bool IsBoiliad()
        {
            return _boilad;
        }
        public bool IsEmpty()
        {
            return _empty;
        }
    }
}
