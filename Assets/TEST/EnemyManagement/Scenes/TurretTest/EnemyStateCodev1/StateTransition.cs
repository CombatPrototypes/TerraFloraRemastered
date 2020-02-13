using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.Conditions;

namespace Enemy.States
{
    public class StateTransition
    {

        public State m_nextState = null;
        public List<ICondition> conditions = new List<ICondition>();

        public State NextState => m_nextState;

        public bool ShouldTransition()
        {
            foreach (var condition in conditions)
            {
                if (!condition.IsMet())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
