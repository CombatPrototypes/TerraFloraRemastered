using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;


[CreateAssetMenu(fileName = "New Behaviour", menuName = "StateCode/Behaviours/HorShift", order = 1)]
public class bHorizontalShift : SO_Behaviour
{
    public float DistanceToShift = 0;
    public bool left = false;


    public override void Action(StateController controller)
    {
        float modifier = left ? -1 : 1;


        controller.gameObject.transform.position += (modifier * (Vector3.right * DistanceToShift)) * Time.deltaTime;
    }

    
}
