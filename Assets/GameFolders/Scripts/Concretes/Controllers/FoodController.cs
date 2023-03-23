using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class FoodController : MonoBehaviour
    {
        [SerializeField] private GameObject choppedFood;
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
                    
                    switch (knifeDamage)
                    {
                        case 1:
                            slice[0].transform.position = transform.position;
                            slice[0].SetActive(true);
                            break;
                        case 2:
                            slice[1].transform.position = transform.position;
                            slice[1].SetActive(true);
                            break;
                        case 3:
                            ChoppedFoodTransform();
                            Destroy(gameObject);
                            slice[0].SetActive(false);
                            slice[1].SetActive(false);
                            choppedFood.SetActive(true);
                            break;
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

        private void ChoppedFoodTransform()
        {
            choppedFood.transform.position = transform.position;
        }
    }
}

