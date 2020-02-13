using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy.States;


namespace Enemy.Conditions
{
    public class PlayerInRange : StateTransitionCondition
    {
        public override bool IsMet()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                return true;
            }

            return false;
        }
    }
}