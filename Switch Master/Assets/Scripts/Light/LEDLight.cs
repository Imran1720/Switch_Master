using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class LEDLight : MonoBehaviour
{
    [Header("Light Image")]
    [SerializeField] private Image targetLED;

    [Header("Light Glow")]
    [SerializeField] private Image glowSource;


    private Color lightOnColor;
    private Color lightOffColor;

    private bool isLightOn;
    public void InitializeData(Color onColor, Color offColor)
    {
        isLightOn = true;
        lightOnColor = onColor;
        lightOffColor = offColor;
        targetLED.color = lightOnColor;
        glowSource.color = lightOffColor;
        ToggleLEDLight();
    }

    public void ToggleLEDLight()
    {
        isLightOn = !isLightOn;
        targetLED.color = isLightOn ? lightOnColor : lightOffColor;
        glowSource.enabled = isLightOn;
    }
}
