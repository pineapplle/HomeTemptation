using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHit : EventObject
{
    protected override void Enter()
    {
        UiCtrl.Me.OffsetHp(100);
        CloseTrigger();
    }
}
