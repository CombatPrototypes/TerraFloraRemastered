using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomPhysics.Base
{ 
    [RequireComponent(typeof(Rigidbody))]
    public class PhysicsObject : MonoBehaviour
    {
        public float gravityModifier = 1;
        public float minGroundNormalY = 0.65f;

        protected Vector3 targetVelocity = Vector3.zero;
        protected Rigidbody rb;
        protected Vector3 velocity = Vector3.zero;
        protected bool isGrounded = false;
        protected Vector3 groundNormal = Vector3.zero;
        
        protected RaycastHit[] hitBuffer = new RaycastHit[16];
        protected List<RaycastHit> hitBufferList = new List<RaycastHit>();

        protected const float minMoveDistance = 0.001f;
        protected const float shellRadius = 0.01f;

        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Start()
        {

        }

        void Update()
        {
            targetVelocity = Vector3.zero;
            ComputeVelocity();
        }

        protected virtual void ComputeVelocity() { }


        private void FixedUpdate()
        {
            velocity += gravityModifier * Physics.gravity * Time.deltaTime;
            velocity.x = targetVelocity.x;

            isGrounded = false;

            Vector3 delta = velocity * Time.deltaTime;
            // TODO figure this out for 3d, only works for 2d right now
            Vector3 moveAlongGround = new Vector3(groundNormal.y, -groundNormal.x, 0);

            Vector3 move = moveAlongGround * delta.x;

            Movement(move, false);
            
            move = Vector3.up * delta.y;

            Movement(move, true);
        }


        void Movement(Vector3 moveVector, bool yMovement)
        {
            float distance = moveVector.magnitude;

            if(distance > minMoveDistance)
            {
                hitBuffer = rb.SweepTestAll(moveVector, distance + shellRadius);
                int count = hitBuffer.Length;

                hitBufferList.Clear();

                for (int i = 0; i < count; i++)
                {
                    hitBufferList.Add(hitBuffer[i]);
                }


                for (int i = 0; i < hitBufferList.Count; i++)
                {
                    Vector3 currentNormal = hitBufferList[i].normal;

                    if(currentNormal.y > minGroundNormalY)
                    {
                        isGrounded = true;
                        if (yMovement)
                        {
                            groundNormal = currentNormal;
                            currentNormal.x = 0;
                        }
                    }

                    // difference between velocity and current normal to determine if player's velocity
                    // needs to be substracted if they are going to continue colliding with an object 
                    // in the next frame
                    float projection = Vector3.Dot(velocity, currentNormal);

                    if(projection < 0)
                    {
                        velocity = velocity - projection * currentNormal;
                    }

                    float modifiedDistance = hitBufferList[i].distance - shellRadius;

                    distance = modifiedDistance < distance ? modifiedDistance : distance;
                }



            }

            rb.position += moveVector.normalized * distance;
        }
    }
}