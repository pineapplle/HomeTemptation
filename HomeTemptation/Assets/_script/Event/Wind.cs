using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : EventObject
{
    protected override void Enter()
    {
        Raindrop.Wind = 15;
    }

    protected override void Exit()
    {
        Raindrop.Wind = 0;
    }
}
