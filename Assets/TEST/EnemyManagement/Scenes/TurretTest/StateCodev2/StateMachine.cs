using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;



namespace StateCode.Base
{
    public class StateMachine
    {
        public StateMachine(SO_State _startingState, SO_State _remainState, StateController _controller)
        {
            controller = _controller;
            
            remainState = _remainState;
            ChangeState(_startingState);
            ConnectToController(this);
        }



        public StateController controller;

        public SO_State CurrentState { get; private set; }

        public SO_State remainState;

        public SO_State nextState;


        public void Tick()
        {
            CurrentState?.UpdateState(controller, this);
        }
        public void ChangeState(SO_State state)
        {
            CurrentState?.onExit(controller);

            CurrentState = state;

            CurrentState?.onEnter(controller);
        }

        public void SetStateToCheck(SO_State state)
        {
            if (state == remainState)
            {
                return;
            }
            else
            {
                nextState = state;
                ChangeState(nextState);
            }

        }

        public void ConnectToController(StateMachine machine)
        {
            controller._stateMachine = machine;
        }

    }
}
