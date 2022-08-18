

namespace Head_First.Ducks
{
    internal abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public Duck ()
        {
            //_flyBehavior = new FlyWithWings ();
            //_quackBehavior = new Quack();
        }

        public void PerfomQuack()
        {
            _quackBehavior.Quack();
        }
        public void PerfomFly()
        {
            _flyBehavior.Fly();
        }
        public void Swim()
        {

        }
        public abstract void Display();

        public void SetPerfomQuack(IQuackBehavior quack)
        {
            _quackBehavior = quack;
        }
        public void SetPerfomansFly(IFlyBehavior fly)
        {
            _flyBehavior = fly;
        }

    }
}
