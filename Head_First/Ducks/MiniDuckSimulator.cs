using System;

namespace Head_First.Ducks
{
    class MiniDuckSimulator
    {
        public static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerfomQuack();
            mallard.PerfomFly();

            Duck model = new ModelDuck();
            model.PerfomFly();
            model.SetPerfomansFly(new FlyRocketPowered());
            Console.WriteLine(" ");
            model.PerfomFly();
        }
        
    }
}