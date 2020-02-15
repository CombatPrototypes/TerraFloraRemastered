using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.Player
{
    public class PlayerController : StateController
    {
        private Rigidbody m_rigid;
        private StateMachine m_machine;

        private void Start()
        {
            //base._rigidbody = GetComponent<Rigidbody>();
            m_rigid = base._rigidbody;

            m_machine = base._stateMachine;
        }

    }
}