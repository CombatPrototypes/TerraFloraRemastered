using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.ScriptableObjs;
using StateCode.Base;

[CreateAssetMenu(fileName = "New Behaviour", menuName = "StateCode/Behaviours/Scale", order = 3)]
public class bScaleObject : SO_Behaviour
{

    public bool grow = false;
    public float scaleMultiplier = 0;

    public override void Action(StateController controller)
    {
        ScaleObject(controller);
    }

    void ScaleObject(StateController controller)
    {
        float modifier = grow ? -1 : 1;
        Vector3 targetScale = Vector3.one;
        targetScale *= (modifier * (scaleMultiplier * Time.deltaTime));


        controller.transform.localScale += targetScale;
    }
}
