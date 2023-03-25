using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField] private GameObject canvasPanel;

    private Image panelImage;
    
    private void Start()
    {
        panelImage = canvasPanel.GetComponent<Image>();
    }

    private void Update()
    {
        if (panelImage.color.a == 0)
        {
            canvasPanel.SetActive(false);
        }
    }
}
