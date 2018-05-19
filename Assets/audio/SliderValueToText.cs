﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour {

    public Slider sliderUI;
    private Text textSliderValue;
    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }
    public void ShowSliderValue() {
        string sliderMessage = "Audio = " +
        sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}
