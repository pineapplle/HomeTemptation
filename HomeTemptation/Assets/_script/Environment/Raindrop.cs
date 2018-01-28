using UnityEngine;

public class Raindrop : MonoBehaviour
{
    public static float Wind;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            return;
        }
        if (other.gameObject.tag == "Player")
        {
            UiCtrl.Me.OffsetHp(50);
            Player.Me.RainDropHit();
        }
        Destroy(gameObject);
    }
}
