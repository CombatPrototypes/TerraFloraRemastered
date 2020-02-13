using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StateCode.Interfaces
{
    public interface IState
    {
        IState ProcessTransitions();
        void onEnter();
        void onExit();

    }
}
