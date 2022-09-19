using System;

namespace TemplateMethod
{
    internal class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrands();
            PourInCup();
            AddSugarAndMilk();
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk ");
        }

        private void PourInCup()
        {
           Console.WriteLine("Pouring into cup");
        }

        private void BrewCoffeeGrands()
        {
           Console.WriteLine(" Dripping Coffe through");         
        }

        private void BoilWater()
        {
           Console.WriteLine("Boiling water");
        }
    }
}
