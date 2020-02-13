using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Interfaces;



namespace StateCode.Base
{
    public class StateMachine
    {
        public StateMachine(IState startingState) => ChangeState(startingState);

        public IState CurrentState { get; private set; }

        public void ChangeState(IState state)
        {
            CurrentState?.onExit();

            CurrentState = state;

            CurrentState?.onEnter();
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
