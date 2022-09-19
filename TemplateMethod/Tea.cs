using System;


namespace TemplateMethod
{
    internal class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }
            private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
