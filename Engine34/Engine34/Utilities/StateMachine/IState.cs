﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine34.Utilities.StateMachine
{
    public interface IState
    {
        void Enter();
        void Handle();
        void Exit();
    }
}
