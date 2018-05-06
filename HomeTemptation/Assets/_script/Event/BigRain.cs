using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRain : EventObject
{
    public int Count;
    protected override void Enter()
    {
        RainCtrl.Count = Count;
    }

    protected override void Exit()
    {
        RainCtrl.Count = 3;
    }
}