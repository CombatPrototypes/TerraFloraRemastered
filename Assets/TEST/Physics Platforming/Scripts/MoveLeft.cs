using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomPhysics.Base
{
    public class MoveLeft : PhysicsObject
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            targetVelocity = Vector3.left;
        }
    }
}