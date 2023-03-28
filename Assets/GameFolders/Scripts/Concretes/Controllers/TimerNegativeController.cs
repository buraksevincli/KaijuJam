using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerNegativeController : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private TMP_Text text;

    [SerializeField] private float barValue = 0.5f;
    [SerializeField] private float duration;
    [SerializeField] private int increaseCount = 2500;
    [SerializeField] private int maxCount = 8000000;
    [SerializeField] private string lastText = "8.000.000";
        
    private float _currentTime;
    private int _textCount;
    
    private void Start()
    {
        _currentTime = barValue;
    }

    private void Update()
    {
            
        timerImage.fillAmount = _currentTime;
        if (timerImage.fillAmount > 0.8f)
        {
            _currentTime -= Time.deltaTime/duration;
        }

        if (_textCount < maxCount)
        {
            text.text = (_textCount+=increaseCount).ToString();
        }
        else
        {
            text.text = lastText;
        }
            

    }
}
