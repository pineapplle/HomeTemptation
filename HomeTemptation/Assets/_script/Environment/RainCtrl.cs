using UnityEngine;

public class RainCtrl : MonoBehaviour
{
    public Raindrop Raindrop;

    public static float Invatial = 0.5f;
    public static int Count = 3;

    private float _timer;

    void Start()
    {
        Count = 3;
    }

    void Update()
    {
        if (_timer > Invatial)
        {
            _timer -= Invatial;
            CreateDrop();
        }
        _timer += Time.deltaTime;
    }

    private void CreateDrop()
    {
        for (int i = 0; i < Count; i++)
        {
            var x = transform.position.x + Random.Range(-15f, 15f);
            var y = transform.position.y;
            var instantiate = Instantiate(Raindrop.gameObject);
            instantiate.transform.position = new Vector3(x, y, 0);
        }
    }
}
