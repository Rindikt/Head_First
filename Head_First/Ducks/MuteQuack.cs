
namespace Head_First.Ducks
{
    internal class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
