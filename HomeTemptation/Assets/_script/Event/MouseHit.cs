using UnityEngine;

public class MouseHit : EventObject
{
    protected override void Tick()
    {
        transform.position += Vector3.left * 3 * Time.deltaTime;
    }

    protected override void Enter()
    {
        UiCtrl.Me.OffsetHp(100);
        CloseTrigger();
    }
}
