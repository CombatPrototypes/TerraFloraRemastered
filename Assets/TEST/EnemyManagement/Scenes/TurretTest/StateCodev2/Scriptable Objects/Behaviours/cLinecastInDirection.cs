using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;


[CreateAssetMenu(fileName = "New Condition", menuName = "StateCode/Conditions/LineCast", order = 3)]
public class cLinecastInDirection : SO_Condition
{
    public Vector3 direction = Vector3.zero;
    public float distToCheck = 0;
    public LayerMask layerToCheck;

    public override bool Decide(StateController controller)
    {
        return PerformLineCast(controller, direction, distToCheck);
    }

    bool PerformLineCast(StateController controller, Vector3 dir, float distance)
    {
        Vector3 start = controller.transform.position;
        Vector3 end = start;

        end += dir * distance;
        Debug.DrawLine(start, end);

        return (Physics.Linecast(start, end, layerToCheck));
        

    }

}
