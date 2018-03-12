using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sewer : EventObject
{
    public override void Trigger()
    {
        CloseTrigger();
        var positionX = transform.GetChild(2).transform.position.x;
        Player.Me.transform.position = new Vector3(positionX, Player.Me.transform.position.y);
    }
}
