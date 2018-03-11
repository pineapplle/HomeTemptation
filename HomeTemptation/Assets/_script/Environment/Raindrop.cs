using UnityEngine;

public class Raindrop : MonoBehaviour
{
    public static float Wind;
    private float _speed;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, Wind);
        _speed += Time.deltaTime * 5f;
        transform.position -= transform.up * _speed * Time.deltaTime;
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
