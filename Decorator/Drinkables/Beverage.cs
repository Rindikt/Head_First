using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Beverage
    {
        protected string description;
        bool milk;
        bool mocha;
        bool whip;


        public void GetDescription() { }

        public abstract float Cost();
    }
}
