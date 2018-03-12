using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRain : EventObject
{
    protected override void Enter()
    {
        RainCtrl.Count = 15;
    }

    protected override void Exit()
    {
        RainCtrl.Count = 3;
    }
}
