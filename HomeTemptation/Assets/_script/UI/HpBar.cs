using UnityEngine;

public class HpBar : MonoBehaviour
{
    private const int MaxDamage = 1000;
    private RectTransform _hpBar;

    void Awake()
    {
        _hpBar = (RectTransform)transform.GetChild(0);

    }

    public void DamageChange(int value)
    {
        var size = _hpBar.sizeDelta;
        size.x = size.x + value;
        if (size.x > 1000)
        {
            UiCtrl.Me.Lose();
        }
        size.x = Mathf.Clamp(size.x, 0, MaxDamage);
        _hpBar.sizeDelta = size;
    }
}
