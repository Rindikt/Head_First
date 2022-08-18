
namespace Head_First.Ducks
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("This duck can't fly");
        }
    }
}
