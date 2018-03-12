using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Speed = 1;
    public float Distance = 50;

    private float _distance;
    private float _startPoint;
    void Start()
    {
        _startPoint = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        var step = Speed * Time.deltaTime;
        _distance += step;
        transform.position += new Vector3(-step, 0);
        if (_distance > Distance)
        {
            transform.position = new Vector3(_startPoint, transform.position.y);
            _distance = 0;
        }
    }
}
