using UnityEngine;

public class Rabbit : EventObject
{
    public override void Trigger()
    {
        CloseTrigger();
        Player.Me.Slip(150);
    }
}
