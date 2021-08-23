﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSystem
{
    public class StateMachine<TState> where TState : IState<TState>
    {
        public Dictionary<string, TState> _states = new Dictionary<string, TState>();

        public void RegisterState(string name, TState state)
        {
            state.StateMachine = this;
            _states.Add(name, state);
        }

        public TState CurrentState { get; internal set; }

        public void MoveTo(string name)
        {
            var state = _states[name];

            CurrentState?.OnExit();

            CurrentState = state;

            CurrentState?.OnEnter();
        }

    }
}
