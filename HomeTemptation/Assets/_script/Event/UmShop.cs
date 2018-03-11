using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmShop : EventObject
{
    public override void Trigger()
    {
        CloseTrigger();
        var umbera = Umbera.Get();
        umbera.transform.SetParent(Player.Me.transform);
        umbera.transform.localPosition = Vector3.zero;
        umbera.transform.localEulerAngles = Vector3.zero;
    }
}
