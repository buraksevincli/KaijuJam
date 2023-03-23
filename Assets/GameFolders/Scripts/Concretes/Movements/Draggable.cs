using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Draggable : MonoBehaviour
    {
        private Vector2 difference = Vector2.zero;

        private void OnMouseDown()
        {
            difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        }

        private void OnMouseDrag()
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        }
    }
}

