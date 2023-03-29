using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate2Controller : MonoBehaviour
{
    [SerializeField] private GameObject plate;
    private void Start()
    {
        if (GameManager.Instance.Plate2)
        {
            plate.SetActive(true);
        }
        else
        {
            plate.SetActive(false);
        }
    }
}
