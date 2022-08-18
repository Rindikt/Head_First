
namespace Head_First.Ducks
{
    internal class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("The duck is quack");
        }
    }
}
