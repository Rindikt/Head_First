using System;
using System.Collections;

namespace Factory
{
    internal abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough ...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(toppings[i]);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal sleces");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string GetName()
        {
            return name;
        }
    }
}
