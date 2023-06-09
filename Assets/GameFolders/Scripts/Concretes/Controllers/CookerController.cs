using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class CookerController : MonoBehaviour
    {
        [SerializeField] private GameObject prepairButton;
        [SerializeField] private GameObject _audio;

        private bool food1,food2,food3,food4 = false;
        
        private void Update()
        {
            if (food1 && food2 && food3 && food4)
            {
                prepairButton.SetActive(true);
            }
            else
            {
                prepairButton.SetActive(false);
            }
            
            if (food1 || food2 || food3 || food4)
            {
                _audio.SetActive(true);
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Food13"))
            {
                food1= true;
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food11"))
            {
                food2= true;
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food22"))
            {
                food3= true;
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food32"))
            {
                food4= true;
                Destroy(col.gameObject);
            }
        }


        public void PreparedFood()
        {
            
            if (GameManager.Instance.GodIndex ==2)
            {
                GameManager.Instance.Plate1 = true;
                GameManager.Instance.GodIndex++;
                SceneManager.LoadScene("Tavern");
            }
            else
            {
                GameManager.Instance.Plate2 = true;
                GameManager.Instance.GenIndex++;
                SceneManager.LoadScene("Tavern2");
            }
        }
    }
}

