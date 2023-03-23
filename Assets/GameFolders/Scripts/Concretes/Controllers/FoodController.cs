using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class FoodController : MonoBehaviour
    {
        [SerializeField] private GameObject[] choppedFood;
        [SerializeField] private GameObject[] slice;

        private bool cuttable;
        private int knifeDamage;
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("ChoppingBoard"))
            {
                cuttable = true;
            }
            
            if (col.gameObject.CompareTag("Knife"))
            {
                if (cuttable)
                {
                    knifeDamage++;
                    
                    if (knifeDamage == 1)
                    {
                        slice[0].SetActive(true);
                    }

                    if (knifeDamage == 2)
                    {
                        slice[1].SetActive(true);
                    }

                    if (knifeDamage == 3)
                    {
                        Destroy(gameObject);
                        slice[0].SetActive(false);
                        slice[1].SetActive(false);
                        choppedFood[0].SetActive(true);
                        choppedFood[1].SetActive(true);
                        choppedFood[2].SetActive(true);
                    }
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("ChoppingBoard"))
            {
                cuttable = false;
            }
        }
    }
}

