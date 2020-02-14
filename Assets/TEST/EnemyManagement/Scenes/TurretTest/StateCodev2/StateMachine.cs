using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;



namespace StateCode.Base
{
    public class StateMachine
    {
        public StateController controller;
        public StateMachine(SO_State startingState) => ChangeState(startingState);

        public SO_State CurrentState { get; private set; }

        public void ChangeState(SO_State state)
        {
            //CurrentState?.onExit();

            CurrentState = state;

            //CurrentState?.onEnter();
        }

        public void Tick()
        {
            //SO_State nextState = CurrentState.ProcessTransitions(controller);

            //if (nextState != null)
            //{
            //    ChangeState(nextState);
            //}
        }
    }
}
