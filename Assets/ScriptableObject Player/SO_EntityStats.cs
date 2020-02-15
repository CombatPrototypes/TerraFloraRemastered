using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateCode.ScriptableObjs
{
    [CreateAssetMenu(fileName = "Stats", menuName = "StateCode/New Stats", order = 5)]
    public class SO_EntityStats : ScriptableObject
    {
        public float moveSpeed = 0;
        public float runSpeed = 0;

    }
}