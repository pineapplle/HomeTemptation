using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private const float Min = 0;
    private const float Max = 57;

    void Start()
    {

    }

    void LateUpdate()
    {
        var x = Player.Me.transform.position.x;
        x = Mathf.Clamp(x, Min, Max);
        var pos = transform.position;
        pos.x = x;
        transform.position = pos;
    }
}
