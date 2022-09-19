using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            if (_gumballMachine.GetCount()==0)
            {
                _gumballMachine.SetState(_gumballMachine.soldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got tho gomballs for your quarter");
                if (_gumballMachine.GetCount()>0)
                {
                    _gumballMachine.SetState(_gumballMachine.noQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumball");
                    _gumballMachine.SetState(_gumballMachine.soldOutState);
                }
            }
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InserdQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
