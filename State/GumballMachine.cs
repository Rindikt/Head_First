using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class GumballMachine
    {
        public IState soldOutState;
        public IState noQuarterState;
        public IState hasQuarterState;
        public IState soldState;
        public IState winnerState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            this.count = numberGumballs;
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            if (numberGumballs >0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void InsertQuarter()
        {
            state.InserdQuarter();
        }

        public void EjectQuarter()
        {
           state.EjectQuarter();
        }

        public void TurnCrank()
        {
           state.TurnCrank();
           state.Dispense();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
        }
        public int GetCount()
        {
            return count;
        }
    }
}
