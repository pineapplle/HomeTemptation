using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private bool _playerIn;
    private GameObject _flag;

    void Start()
    {
        _flag = transform.GetChild(0).gameObject;
    }

    void Update()
    {

    }

    private IEnumerator ShowFlag()
    {
        _flag.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        _flag.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _playerIn = true;
        }
        if (other.gameObject.tag == "Car")
        {
            StartCoroutine(ShowFlag());
            if (_playerIn)
            {
                UiCtrl.Me.OffsetHp(100);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _playerIn = false;
        }
    }
}
