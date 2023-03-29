using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernMusicManager : MonoBehaviour
{
    
    public static TavernMusicManager Instance;

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
                _audioSource.time = 0f;
                break;
            case 2:
                _audioSource.mute = false;
                break;
            case 3:
                _audioSource.mute = false;
                break;
            case 5:
                _audioSource.mute = false;
                break;
            case 6:
                _audioSource.mute = false;
                break;
            case 8:
                _audioSource.mute = false;
                break;
            default:
                _audioSource.mute = true;
                break;
        }
    }
}
