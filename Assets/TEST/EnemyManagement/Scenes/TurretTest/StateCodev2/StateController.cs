using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;

namespace StateCode.Base
{
    public class StateController : MonoBehaviour
    {
        public SO_State startingState = null;

        private void Update()
        {
            startingState?.UpdateState(this);
        }
    }
}