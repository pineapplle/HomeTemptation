using UnityEngine;

public class FloatButton : MonoBehaviour
{
    private EventObject _trackNode;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void LateUpdate()
    {
        if (_trackNode != null)
        {
            var worldToScreenPoint = Camera.main.WorldToScreenPoint(_trackNode.transform.position + Vector3.up);
            transform.position = worldToScreenPoint;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _trackNode.Trigger();
        }
    }

    public void Show(EventObject node)
    {
        _trackNode = node;
        gameObject.SetActive(true);
    }

    public void Close(EventObject node)
    {
        if (node == _trackNode)
        {
            gameObject.SetActive(false);
        }
    }
}
