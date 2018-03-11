using UnityEngine;

public class EventObject : MonoBehaviour
{
    private Collider2D _trigger;

    void Start()
    {
        var componentsInChildren = GetComponentsInChildren<Collider2D>();
        foreach (var col in componentsInChildren)
        {
            if (col.isTrigger)
            {
                _trigger = col;
            }
        }
        Init();
    }

    void Update()
    {
        Tick();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Enter();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Exit();
        }
    }

    protected virtual void Init()
    {

    }

    protected virtual void Tick()
    {

    }

    protected virtual void Enter()
    {
        UiCtrl.Me.ShowButton(this);
    }

    protected virtual void Exit()
    {
        UiCtrl.Me.CloseButton(this);
    }

    public virtual void Trigger()
    {
        CloseTrigger();
        UiCtrl.Me.OffsetHp(-300);
    }

    protected void CloseTrigger()
    {
        _trigger.enabled = false;
    }

    protected void OpenTrigger()
    {
        _trigger.enabled = true;
    }
}
