using UnityEngine;

public class Umbera : MonoBehaviour
{
    public static Umbera Get()
    {
        var res = Resources.Load("Scene/Prefabs/un");
        var obj = (GameObject)Instantiate(res);
        return obj.AddComponent<Umbera>();
    }

    private float _keepTime = 20f;

    void Start()
    {

    }

    void Update()
    {
        _keepTime -= Time.deltaTime;
        if (_keepTime < 0)
        {
            Destroy(gameObject);
        }
    }
}
