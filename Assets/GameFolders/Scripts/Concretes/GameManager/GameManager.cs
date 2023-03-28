using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int GodIndex { get; set; }
    public int GenIndex { get; set; }
    public bool Plate1 { get; set; }
    
    private void Awake()
    {
        SingletonPattern();
    }

    private void SingletonPattern()
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
    }
}
