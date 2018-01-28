using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiCtrl : MonoBehaviour
{
    public static UiCtrl Me;
    public GameObject Message;

    private HpBar _hpBar;
    private FloatButton _floatButton;

    private GameObject _win;
    private GameObject _lose;
    private bool _end;

    void Start()
    {
        Me = this;
        _hpBar = transform.GetChild(0).gameObject.AddComponent<HpBar>();
        _floatButton = transform.GetChild(1).gameObject.AddComponent<FloatButton>();
        _win = transform.GetChild(3).gameObject;
        _lose = transform.GetChild(2).gameObject;

        _win.gameObject.SetActive(false);
        _lose.gameObject.SetActive(false);
    }

    void Update()
    {
        if (_end)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        Player.Me.enabled = false;
        _end = true;
    }

    public void ShowMessage(Vector3 worldPoint, string str)
    {
        var instantiate = Instantiate(Message.gameObject);
        instantiate.transform.SetParent(transform);

        var message = instantiate.GetComponent<Message>();
        message.Context = str;
        message.WorldPoint = worldPoint;
    }

    public void Win()
    {
        _win.gameObject.SetActive(true);
        EndGame();
    }

    public void Lose()
    {
        _lose.gameObject.SetActive(true);
        EndGame();
    }

    public void OffsetHp(int value)
    {
        _hpBar.DamageChange(value);

        var pos = Player.Me.transform.position + new Vector3(0, 2);
        var str = value.ToString();
        if (value > 0)
        {
            str = "+" + str;
        }
        ShowMessage(pos, str + "潮湿度");
    }

    public void ShowButton(EventObject node)
    {
        _floatButton.Show(node);
    }

    public void CloseButton(EventObject node)
    {
        _floatButton.Close(node);
    }
}
