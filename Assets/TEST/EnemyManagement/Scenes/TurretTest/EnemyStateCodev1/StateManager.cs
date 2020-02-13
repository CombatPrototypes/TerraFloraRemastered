using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.Conditions;
using UnityEngine.Events;

namespace Enemy.States 
{ 
    public class StateManager : MonoBehaviour
    {
        
        public List<StateTransitionCondition> conditions = new List<StateTransitionCondition>();
    }
}
