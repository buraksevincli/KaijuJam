using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class CameraShakeControl : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey("S"))
        {
            gameObject.GetComponent<CameraShakeControl>().Shake(5, 3, 01f, 2f);
        }

    }
}
