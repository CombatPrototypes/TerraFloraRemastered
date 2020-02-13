using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Interfaces;

namespace StateCode.Base
{
    public abstract class StateBehaviour
    {
        public virtual void Action()
        {
            Debug.Log("Running Behaviour");
        }
    }
}
