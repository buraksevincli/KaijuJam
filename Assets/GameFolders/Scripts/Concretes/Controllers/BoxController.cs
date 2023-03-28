using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] private GameObject food;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private BoxCollider2D _boxCollider;
    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnMouseDown()
    {
        food.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        spriteRenderer.sortingOrder = 4;
        Destroy(_boxCollider);
    }
}
