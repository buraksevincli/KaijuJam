using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlateController : MonoBehaviour
    {
        [SerializeField] private GameObject plate;
        private void OnEnable()
        {
            if (GameManager.Instance.Plate1)
            {
                plate.SetActive(true);
            }
            else
            {
                plate.SetActive(false);
            }
        }
    }
}

