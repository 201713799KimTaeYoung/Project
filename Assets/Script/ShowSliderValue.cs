using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSliderValue : MonoBehaviour
{
    public Text sliderValue;
    
    public void SetSliderValue(float value)
    {
        sliderValue.text = value.ToString("N0");
    }
    public void SetSliderValueInt(float value)
    {
        sliderValue.text = ((int)value).ToString("N0");
    }

}
