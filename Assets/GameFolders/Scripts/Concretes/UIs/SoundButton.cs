using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{

    [SerializeField] GameObject sliderActivator;
    [SerializeField] GameObject sliderDeactivator;
    [SerializeField] GameObject slider;

    public void SliderActivator()
    {
        sliderActivator.SetActive(false);
        sliderDeactivator.SetActive(true);
        slider.SetActive(true);
    }
    public void SliderDeactivator()
    {
        sliderActivator.SetActive(true);
        sliderDeactivator.SetActive(false);
        slider.SetActive(false);
    }
}
