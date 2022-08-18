using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    internal class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new Cheese();
        }

        public Clams createClams()
        {
            return new Clams();
        }

        public Dough createDough()
        {
            return new Dough();
        }

        public Pepperoni createPepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce createSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] createVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
