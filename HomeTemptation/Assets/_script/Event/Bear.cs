using System.Collections;
using UnityEngine;

public class Bear : EventObject
{
    private Animator _animator;

    protected override void Init()
    {
        _animator = transform.GetComponent<Animator>();
    }

    public override void Trigger()
    {
        Down();
        StartCoroutine(DelayStand());
    }

    private IEnumerator DelayStand()
    {
        yield return new WaitForSeconds(3);
        Stand();
    }

    private void Stand()
    {
        OpenTrigger();
        _animator.Play("stand", 0, 0);
    }

    private void Down()
    {
        CloseTrigger();
        _animator.Play("down", 0, 0);
    }
}
