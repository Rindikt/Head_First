using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InserdQuarter()
        {
            Console.WriteLine("You can’t insert a quarter, the machine is sold out”");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
        }


        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
            
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
