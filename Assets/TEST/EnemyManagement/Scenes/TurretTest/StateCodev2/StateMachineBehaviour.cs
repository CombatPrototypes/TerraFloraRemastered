using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;

namespace StateCode.Base
{
    public class StateMachineBehaviour : MonoBehaviour
    {
        public SO_State m_StartingState = null;

        private StateMachine m_StateMachine;

        private StateMachine StateMachine
        {
            get
            {
                if (m_StateMachine != null) { return m_StateMachine; }

                m_StateMachine = new StateMachine(m_StartingState);
                return m_StateMachine;
            }
        }

        private void Update() => StateMachine.Tick();

        public void ChangeState(SO_State state) => StateMachine.ChangeState(state);
    }
}
