using System;

namespace State
{
    internal class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InserdQuarter()
        {
            Console.WriteLine("You can't insart anther Quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.noQuarterState);
        }


        public void TurnCrank()
        {
            var rand = new Random();
            Console.WriteLine("You turned...");
            int winner = rand.Next(0, 10);
            if (winner == 0 && _gumballMachine.GetCount()>1)
            {
                _gumballMachine.SetState(_gumballMachine.winnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.soldState);
            }
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
