using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : EventObject
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Enter()
    {
        Destroy(gameObject);
        Player.Me.Slip(5);
    }
}
