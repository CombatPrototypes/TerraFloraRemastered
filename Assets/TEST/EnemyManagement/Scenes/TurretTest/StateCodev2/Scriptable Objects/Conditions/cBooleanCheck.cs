using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;


[CreateAssetMenu(fileName = "New Condition", menuName = "StateCode/Conditions/BoolCheck", order = 2)]
public class cBooleanCheck : SO_Condition
{

    public override bool Decide(StateController controller)
    {
        return isBooleanTrue(controller);
    }

    private bool isBooleanTrue(StateController controller)
    {
        return false;
    }
}
