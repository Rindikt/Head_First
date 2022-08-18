using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Singleton
    {
        private static Singleton UniqueInstance;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new Singleton();
            }
                return UniqueInstance;
        }
    }
}
