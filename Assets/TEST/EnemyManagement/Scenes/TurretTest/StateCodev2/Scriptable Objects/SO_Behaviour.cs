using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.ScriptableObjs
{
    public abstract class SO_Behaviour : ScriptableObject
    {
        public abstract void Action(StateController controller);


        private void OnEnable()
        {
            Debug.Log("Behaviour is Active");
        }
        private void OnDisable()
        {
            Debug.Log("Behaviour is Disabled");
        }
    }

    
}