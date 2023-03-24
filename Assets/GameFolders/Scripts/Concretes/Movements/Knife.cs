using System;
using GameFolders.Scripts.Concretes.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Knife : MonoBehaviour
    {
        private Vector2 difference;

        public static bool holdingKnife;
        
        private void OnMouseDown()
        {
            difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        }

        private void OnMouseDrag()
        {
            holdingKnife = true;
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        }

        private void OnMouseExit()
        {
            holdingKnife = false;
        }
    }
}
