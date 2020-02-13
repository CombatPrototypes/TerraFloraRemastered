using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateCode.Base;


namespace StateCode.ScriptableObjs
{
    [CreateAssetMenu(fileName = "State", menuName = "StateCode/New State", order = 2)]
    public class SO_State : ScriptableObject
    {
        public string Name = " ";

        public SO_Behaviour[] Behaviours;

        public void UpdateState(StateController controller)
        {
            DoActions(controller);
        }

        private void DoActions(StateController controller)
        {
            for (int i = 0; i < Behaviours.Length; i++)
            {
                Behaviours[i].Action(controller);
            }
        }
    }
}
