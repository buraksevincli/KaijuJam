using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class CookerController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Food1"))
            {
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food2"))
            {
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food3"))
            {
                Destroy(col.gameObject);
            }
            if (col.gameObject.CompareTag("Food4"))
            {
                Destroy(col.gameObject);
            }
        }

        public void PreparedFood()
        {
            GameManager.Instance.Plate1 = true;
        }
    }
    
}

