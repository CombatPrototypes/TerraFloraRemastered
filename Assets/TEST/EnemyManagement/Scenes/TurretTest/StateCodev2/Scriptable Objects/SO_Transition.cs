using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;

namespace StateCode.ScriptableObjs
{
    [CreateAssetMenu(fileName = "Transition", menuName = "StateCode/New Transition", order = 3)]
    public class SO_Transition : ScriptableObject
    {
        public string Name = " ";
        public List<SO_Condition> conditions = new List<SO_Condition>();
    }
}
