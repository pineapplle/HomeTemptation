using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : EventObject
{
    private float _timer;
    private bool _playerIn;
    private SpriteRenderer _spriteRenderer;

    protected override void Init()
    {
        _spriteRenderer = transform.GetComponent<SpriteRenderer>();
    }

    protected override void Enter()
    {
        SetColor(1);
        _timer = 5;
        _playerIn = true;
    }

    protected override void Exit()
    {
        SetColor(1);
        _playerIn = false;
    }

    protected override void Tick()
    {
        if (!_playerIn)
        {
            return;
        }
        _timer -= Time.deltaTime;
        SetColor(_timer / 5);
        if (_timer < 0)
        {
            StartCoroutine(Lighting());
        }
    }

    private IEnumerator Lighting()
    {
        for (int i = 0; i < 3; i++)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.05f);
            transform.GetChild(0).gameObject.SetActive(false);
            yield return new WaitForSeconds(0.05f);
        }
        UiCtrl.Me.Lose();
    }

    private void SetColor(float percent)
    {
        _spriteRenderer.color = new Color(1, percent, percent, 1);
    }
}
