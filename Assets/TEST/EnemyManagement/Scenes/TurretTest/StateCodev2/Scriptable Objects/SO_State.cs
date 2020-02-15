using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;


namespace StateCode.ScriptableObjs
{
    [CreateAssetMenu(fileName = "State", menuName = "StateCode/New State", order = 2)]
    public class SO_State : ScriptableObject
    {
        public string Name = " ";

        public SO_Behaviour[] Behaviours;
        public SO_Transition[] Transitions;


        public SO_Behaviour OnEnterBehaviour;
        public SO_Behaviour OnExitBehaviour;
        

        public void onEnter(StateController controller)
        {
            if(OnEnterBehaviour == null)
            {
                return;
            }
            else
            {
                OnEnterBehaviour.Action(controller);
            }
        }
        
        public void onExit(StateController controller)
        {
            if(OnEnterBehaviour == null)
            {
                return;
            }
            else
            {
                OnExitBehaviour.Action(controller);
            }
        }


        public void UpdateState(StateController controller, StateMachine stateMachine)
        {
            DoActions(controller);
            ProcessTransitions(controller, stateMachine);
        }

        private void DoActions(StateController controller)
        {
            for (int i = 0; i < Behaviours.Length; i++)
            {
                Behaviours[i].Action(controller);
            }
        }

        public void ProcessTransitions(StateController controller, StateMachine stateMachine)
        {
            foreach (var transition in Transitions)
            {
                bool decisionSuccess = transition.ShouldTransition(controller);

                if (decisionSuccess)
                {
                    stateMachine.SetStateToCheck(transition.trueState);
                }
                else
                {
                    stateMachine.SetStateToCheck(transition.falseState);
                }
            }
        }


    }
}
