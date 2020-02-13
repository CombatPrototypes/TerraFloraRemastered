using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;
using StateCode.Interfaces;


namespace StateCode.States
{
    public class Dormant : State
    {
        public List<StateTransition> transitions = new List<StateTransition>();

        private void Awake()
        {
            SetTransitions(transitions);
        }


        public override void SetTransitions(List<StateTransition> _transitions)
        {
            base.SetTransitions(_transitions);
        }

        public override void onEnter()
        {
            base.onEnter();
        }

        public override void onExit()
        {
            base.onExit();
        }

        public override IState ProcessTransitions()
        {
            return base.ProcessTransitions();
        }
    }
}
