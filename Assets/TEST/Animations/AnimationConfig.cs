using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationConfig : MonoBehaviour
{
    public Animator anim;

    [System.Serializable]
    public struct FloatParameter
    {
        public string name;
        public float value;
    }


    public FloatParameter[] floatParameters;

    void Start()
    {
        foreach (var parameter in floatParameters)
        {
            if(parameter.value > 0)
            {

            }
        }

    }

    // Allow live editing in the Inspector during play mode.
    void OnValidate()
    {
        if (Application.isPlaying)
            Start();
    }
}
