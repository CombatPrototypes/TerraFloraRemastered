using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Interfaces;


namespace StateCode.Base
{
    public abstract class StateCondition
    {
        public virtual bool IsMet()
        {
            return false;
        }
    }
}
