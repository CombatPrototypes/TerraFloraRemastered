using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;

namespace StateCode.Base
{
    public class StateController : MonoBehaviour
    {
        public SO_State startingState = null;

        public SO_State currentState;
        public SO_State remainState;

        public float maxNum = 3;
        public float minNum = -3;
        public float currentNum = 0;

        private void Awake()
        {
            currentState = startingState;
        }

        private void Update()
        {
            currentState?.UpdateState(this);
        }

        public void ChangeState(SO_State nextState)
        {
            if(nextState != remainState)
            {
                currentState = nextState;
            }
        }
    }
}