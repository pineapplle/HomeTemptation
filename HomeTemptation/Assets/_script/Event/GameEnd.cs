using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : EventObject
{
    public override void Trigger()
    {
        UiCtrl.Me.Win();
    }
}
