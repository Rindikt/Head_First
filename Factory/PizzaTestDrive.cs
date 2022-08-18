
namespace Factory
{
    internal class PizzaTestDrive
    {
        public static void Main()
        {
            PizzaStore nyStore = new NYPizzaFactory();
            PizzaStore chicagoStore = new ChicagoPizzaFactory();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName());
        }
    }
}
