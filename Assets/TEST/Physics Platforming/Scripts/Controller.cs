using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CustomPhysics.Base
{
    public class Controller : PhysicsObject
    {
        public float maxSpeed = 7;
        public float jumpStartSpeed = 7;


        void Start()
        {

        }

        protected override void ComputeVelocity()
        {
            Vector3 move = Vector3.zero;

            move.x = Input.GetAxis("Horizontal");

            if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                velocity.y = jumpStartSpeed;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                if(velocity.y > 0)
                {
                    velocity.y = velocity.y * 0.5f;
                }
            }

            targetVelocity = move * maxSpeed;


        }
    }
}