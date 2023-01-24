using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class HelthSlider : MonoBehaviour
{
    public UnityEvent StartEvent;
    public Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        StartEvent.Invoke();
    }

    public void UpdateSlider(floatData obj)
    {
        slider.value = obj.value;
    }
}
