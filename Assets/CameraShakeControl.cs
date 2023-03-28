using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class CameraShakeControl : MonoBehaviour
{
    [SerializeField] private float magnitude=3f;
    [SerializeField] private float roughness=5f;
    [SerializeField] private float fadeInTime=3f;
    [SerializeField] private float fadeOutTime=5f;

    private void Start()
    {
        gameObject.GetComponent<CameraShaker>().ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
    }

    void Update()
    {
    }
}
