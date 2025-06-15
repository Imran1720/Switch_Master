using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LEDLight : MonoBehaviour
{
    [SerializeField] private Image targetLED;
    [SerializeField] private Color lightOnColor;
    [SerializeField] private Color lightOffColor;

    private bool isLightOn;
    private void Start()
    {
        isLightOn = true;
        targetLED.color = lightOnColor;
        ToggleLEDLight();
    }

    public void ToggleLEDLight()
    {
        isLightOn = !isLightOn;
        targetLED.color = isLightOn ? lightOnColor : lightOffColor;
    }
}
