using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLittle : EventObject
{
    public MouseHit[] Parents;

    void Start()
    {
        foreach (var mouseHit in Parents)
        {
            mouseHit.gameObject.SetActive(false);
        }
    }

    protected override void Enter()
    {
        foreach (var mouseHit in Parents)
        {
            mouseHit.gameObject.SetActive(true);
        }
    }
}
