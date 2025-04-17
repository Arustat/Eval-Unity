using UnityEngine;
using UnityEngine.Audio;

public class sound_manager : MonoBehaviour
{
    private AudioClip _coin;

    private AudioSource _audioSource;
    public static sound_manager instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        _coin = Resources.Load<AudioClip>("coin/coin01.ogg");

        _audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayCoin()
    {
        _audioSource.PlayOneShot(_coin);
    }

}
