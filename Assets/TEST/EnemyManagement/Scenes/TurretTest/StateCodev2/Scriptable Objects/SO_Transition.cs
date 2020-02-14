using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.ScriptableObjs
{
    [CreateAssetMenu(fileName = "Transition", menuName = "StateCode/New Transition", order = 3)]
    public class SO_Transition : ScriptableObject
    {
        public List<SO_Condition> conditions = new List<SO_Condition>();

        public SO_State trueState;
        public SO_State falseState;

        // TODO cache a reference to stateController when initializing
        public bool ShouldTransition(StateController controller)
        {
            foreach (var condition in conditions)
            {
                if (!condition.Decide(controller))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
