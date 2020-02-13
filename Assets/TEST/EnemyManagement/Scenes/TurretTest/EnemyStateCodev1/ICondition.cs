using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.Conditions
{
    public interface ICondition
    {
        bool IsMet();
    }
}
