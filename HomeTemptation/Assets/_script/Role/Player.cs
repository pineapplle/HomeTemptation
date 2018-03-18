using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Me;
    private bool _left;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private float _ySpeed;
    private bool _onGround;
    private bool _inputEnable;
    void Awake()
    {
        Me = this;
        _left = true;
        _inputEnable = true;
        _rigidbody2D = transform.GetComponent<Rigidbody2D>();
        _spriteRenderer = transform.GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (!_inputEnable)
        {
            return;
        }
        var hor = InputMove();
        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_onGround)
            {
                _ySpeed = 7f;
            }
        }
        if (!_onGround)
        {
            _ySpeed -= 20 * Time.deltaTime;
        }

        var offset = new Vector2(hor * 5, _ySpeed) * Time.deltaTime;
        var targetPoint = _rigidbody2D.position + offset;
        _rigidbody2D.MovePosition(targetPoint);
    }

    void CheckGround()
    {
        var raycastHit2D = Physics2D.RaycastAll(transform.position + new Vector3(0, 0.1f, 0), Vector2.down, 0.2f, LayerMask.GetMask("Default"));
        foreach (var hit2D in raycastHit2D)
        {
            if (hit2D.collider != null && !hit2D.collider.isTrigger)
            {
                _onGround = true;
                _ySpeed = 0;
                return;
            }
        }
        _onGround = false;
    }

    private int InputMove()
    {
        var hor = 0;
        if (Input.GetKey(KeyCode.A))
        {
            hor = -1;
            if (!_left)
            {
                _left = true;
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            hor = 1;
            if (_left)
            {
                _left = false;
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
        }
        return hor;
    }

    public void RainDropHit()
    {

    }

    public void Slip(int count)
    {
        StartCoroutine(SlipStep(count));
    }

    private IEnumerator SlipStep(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForEndOfFrame();
            transform.position += new Vector3(Time.deltaTime * 20f, 0);
        }
    }
}
