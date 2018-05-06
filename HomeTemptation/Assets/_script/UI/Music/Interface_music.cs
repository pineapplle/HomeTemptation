using UnityEngine;

public class Interface_music : MonoBehaviour
{
    public AudioSource zyaudio;
    public static float volume = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void vol(float v)
    {
        volume = v;
        zyaudio.volume = v;
    }
}
