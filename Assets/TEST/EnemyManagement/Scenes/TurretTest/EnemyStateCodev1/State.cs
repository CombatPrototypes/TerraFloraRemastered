using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.States
{
    public class State : MonoBehaviour, IState
    {
        [SerializeField]
        private List<StateTransition> transitions;

        public void GetTransitions(List<StateTransition> pTransitions)
        {
            if(transitions == null)
            {
                transitions = new List<StateTransition>();
                transitions = pTransitions;
            }
            

            if(transitions != pTransitions)
            {
                transitions = pTransitions;
            }
        }


        public void OnEnter()
        {
            gameObject.SetActive(true);
        }

        public void OnExit()
        {
            gameObject.SetActive(false);
        }

        public IState ProcessTransitions()
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
