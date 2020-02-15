using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;

[CreateAssetMenu(fileName = "New Behaviour", menuName = "StateCode/Behaviours/Patrol", order = 0)]
public class bPatrol : SO_Behaviour
{
    public float distance = 0;

    public List<GameObject> waypoints = new List<GameObject>();

    public override void Action(StateController controller)
    {
        controller.gameObject.transform.position += Vector3.up * distance * Time.deltaTime;
    }

}
