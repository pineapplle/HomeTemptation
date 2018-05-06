using UnityEngine;

public class Raindrop : MonoBehaviour
{
    public static float Wind;
    public GameObject OnHit;
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
        ShowHit();

        if (other.gameObject.tag == "Player")
        {
            UiCtrl.Me.OffsetHp(50);
            Player.Me.RainDropHit();
        }
        Destroy(gameObject);
    }

    private void ShowHit()
    {
        var instantiate = Instantiate(OnHit);
        instantiate.transform.position = transform.position;
        Destroy(instantiate, 0.2f);
    }
}
