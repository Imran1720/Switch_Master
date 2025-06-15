using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightButton : MonoBehaviour
{
    [SerializeField] private LEDLight targetLED;

    [SerializeField] private Button currentLEDButton;


    // Start is called before the first frame update
    void Start()
    {
        currentLEDButton.onClick.AddListener(ToggleLEDLight);
    }

    private void ToggleLEDLight()
    {
        targetLED.ToggleLEDLight();
    }
}
