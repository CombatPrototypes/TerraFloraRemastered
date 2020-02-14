using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;

[CreateAssetMenu(fileName = "New Behaviour", menuName = "StateCode/Conditions/ValueMatch", order = 1)]
public class cValueReached : SO_Condition
{
    public bool checkMax = false;


    public override bool Decide(StateController controller)
    {
        return CompareValues(controller);
    }

    bool CompareValues(StateController controller)
    {
        float valToCheck = checkMax ? controller.maxNum : controller.minNum;
        float current = controller.currentNum;


        if (checkMax && current < valToCheck)
        {
            controller.currentNum += Time.deltaTime;
            return false;
        }
        else if (checkMax && current >= valToCheck)
        {
            controller.currentNum = 0;
            return true;
        }

        if (!checkMax && current > valToCheck)
        {
            controller.currentNum -= Time.deltaTime;
            return false;
        }
        else if(!checkMax && current <= valToCheck)
        {
            controller.currentNum = 0;
            return true;
        }

        return false;
    }
}
