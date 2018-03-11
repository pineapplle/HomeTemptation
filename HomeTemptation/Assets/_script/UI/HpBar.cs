using UnityEngine;

public class HpBar : MonoBehaviour
{
    private const int MaxDamage = 1000;
    private int _currentDamage;
    private RectTransform _hpBar;

    void Awake()
    {
        _hpBar = (RectTransform)transform.GetChild(0);
        _currentDamage = 0;
    }

    public void DamageChange(int value)
    {
        _currentDamage += value;
        if (_currentDamage >= MaxDamage)
        {
            UiCtrl.Me.Lose();
        }
        _currentDamage = Mathf.Clamp(_currentDamage, 0, MaxDamage);
        SetPercent((float)_currentDamage / MaxDamage);
    }

    private void SetPercent(float percent)
    {
        var parent = (RectTransform)transform;
        var size = _hpBar.sizeDelta;
        size.x = parent.rect.size.x * percent;
        _hpBar.sizeDelta = size;
    }
}
