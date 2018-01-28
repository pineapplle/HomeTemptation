using UnityEngine;

public class AnimSpeedSet : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        GetComponent<Animator>().speed = Speed;
    }
}
