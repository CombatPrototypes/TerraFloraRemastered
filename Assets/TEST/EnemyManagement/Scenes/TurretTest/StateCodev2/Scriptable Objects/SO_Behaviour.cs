using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.ScriptableObjs
{
    public abstract class SO_Behaviour : ScriptableObject
    {
        public abstract void Action(StateController controller);
    }
}