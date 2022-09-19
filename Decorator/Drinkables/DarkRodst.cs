using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DarkRodst : Beverage
    {
        public DarkRodst()
        {
        description = "Most Excellent Dark Roast";
            
        }
        public override float Cost()
        {
            float cost = 5;
            return cost;
        }
    }
}
