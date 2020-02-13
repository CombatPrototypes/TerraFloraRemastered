using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.ScriptableObjs
{
    public abstract class SO_Condition : ScriptableObject
    {
        public abstract bool Decide(StateController controller);
    }
}
