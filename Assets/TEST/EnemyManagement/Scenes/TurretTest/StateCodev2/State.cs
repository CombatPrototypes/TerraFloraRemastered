using StateCode.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateCode.Base
{
    public class State : MonoBehaviour, IState
    {
        [SerializeField]
        private List<StateTransition> transitions = new List<StateTransition>();



        public virtual void SetTransitions(List<StateTransition> _transitions)
        {
            transitions = _transitions;
        }

        public virtual void onEnter()
        {
            gameObject.SetActive(true);
        }

        public virtual void onExit()
        {
            gameObject.SetActive(false);
        }

        public virtual IState ProcessTransitions()
        {
            foreach (var transition in transitions)
            {
                if (transition.ShouldTransition())
                {
                    return transition.NextState;
                }
            }

            return null;
        }
    }
}
