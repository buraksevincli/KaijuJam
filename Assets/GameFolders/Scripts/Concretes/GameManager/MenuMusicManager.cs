using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusicManager : MonoBehaviour
{
    public static MenuMusicManager Instance;

    private AudioSource _audioSource;

    private int buildIndex;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;

        switch (buildIndex)
        {
            case 0:
                _audioSource.mute = false;
                break;
            case 1:
                _audioSource.time = 0;
                break;
            case 4:
                _audioSource.mute = false;
                break;
            default:
                _audioSource.mute = true;
                break;
        }
    }
}
