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

        public void UpdateState(StateController controller)
        {
            DoActions(controller);
            ProcessTransitions(controller);
        }

        private void DoActions(StateController controller)
        {
            for (int i = 0; i < Behaviours.Length; i++)
            {
                Behaviours[i].Action(controller);
            }
        }

        public void ProcessTransitions(StateController controller)
        {
            foreach (var transition in Transitions)
            {
                bool decisionSuccess = transition.ShouldTransition(controller);

                if (decisionSuccess)
                {
                    controller.ChangeState(transition.trueState);
                }
                else
                {
                    controller.ChangeState(transition.falseState);
                }
            }
        }


    }
}
