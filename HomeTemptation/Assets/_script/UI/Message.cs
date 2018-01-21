using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    public string Context;
    public Vector2 WorldPoint;

    void Start()
    {
        GetComponentInChildren<Text>().text = Context;
        Destroy(gameObject, 1);
    }

    void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(WorldPoint);
        transform.position = pos;
    }
}
