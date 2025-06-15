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

    [Header("Light Color")]
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
        glowSource.enabled = isLightOn;
    }
}
