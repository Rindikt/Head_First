﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface IState
    {
        void InserdQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
