using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;

namespace StateCode.Player
{
    [CreateAssetMenu(fileName = "New Behaviour", menuName = "StateCode/Behaviours/GoForward", order = 4)]
    public class PB_ForwardMove : SO_Behaviour
    {
        public float _speed = 0;
        public Vector3 _direction = Vector3.zero;
        public Vector3 _position = Vector3.zero;


        public override void Action(StateController controller)
        {
            if(_speed != controller.stats.moveSpeed)
            {
                _speed = controller.stats.moveSpeed;
            }
            
            if(_direction != controller.transform.forward)
            {
                _direction = controller.transform.forward;
            }

            if(_position != controller.transform.position)
            {
                _position = controller.transform.position;
            }

            MoveForward(controller);
        }


        void MoveForward(StateController controller)
        {
            Vector3 newPos = controller._rigidbody.position;
            Vector3 offset = Vector3.zero;


            offset = _direction * _speed * Time.deltaTime;

            newPos += offset;

            controller._rigidbody.MovePosition(newPos);
        }
    }
}