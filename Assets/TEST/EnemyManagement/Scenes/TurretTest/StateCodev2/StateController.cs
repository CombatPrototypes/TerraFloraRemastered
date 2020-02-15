using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;

namespace StateCode.Base
{
    [RequireComponent(
        typeof(Rigidbody), 
        typeof(StateMachineBehaviour)
        )]
    public class StateController : MonoBehaviour
    {
        public SO_EntityStats stats = null;
        public Rigidbody _rigidbody;
        public StateMachine _stateMachine;

        private void Reset()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
    }
}