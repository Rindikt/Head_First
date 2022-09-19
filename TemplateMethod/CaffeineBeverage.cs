using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();

        }

        private void BoilWater()
        {
            Console.WriteLine("");
        }
        protected abstract void Brew();

        private void PourInCup()
        {
            throw new NotImplementedException();
        }
        protected abstract void AddCondiments();



    }
}
