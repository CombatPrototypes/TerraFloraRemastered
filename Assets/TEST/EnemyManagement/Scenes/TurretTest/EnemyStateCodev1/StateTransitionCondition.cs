using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Enemy.States
{
    public abstract class StateTransitionCondition : MonoBehaviour
    {
        public abstract bool IsMet();
    }
}
