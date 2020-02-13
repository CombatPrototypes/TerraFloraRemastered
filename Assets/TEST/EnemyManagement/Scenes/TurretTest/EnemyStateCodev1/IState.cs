using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.States
{
    public interface IState
    {
        IState ProcessTransitions();
        void OnEnter();
        void OnExit();
    }
}
