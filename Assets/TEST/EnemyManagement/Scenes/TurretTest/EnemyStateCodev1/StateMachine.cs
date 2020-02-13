using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.States
{
    public class StateMachine
    {
        public StateMachine(IState startingState) => ChangeState(startingState);

        public IState CurrentState { get; private set; }

        public void ChangeState(IState state)
        {
            CurrentState?.OnExit();

            CurrentState = state;

            CurrentState?.OnEnter();
        }

        public void Tick()
        {
            IState nextState = CurrentState.ProcessTransitions();

            if (nextState != null)
            {
                ChangeState(nextState);
            }
        }
    }
}
