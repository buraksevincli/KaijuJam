using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernMusicManager : MonoBehaviour
{
    [SerializeField] private int activeSceneIndex;
    
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
        
        if (buildIndex == activeSceneIndex)
        {
            _audioSource.mute = false;
        }
        else
        {
            _audioSource.mute = true;
        }

        if (buildIndex == 0)
        {
            _audioSource.time = 0f;
        }
    }
}
