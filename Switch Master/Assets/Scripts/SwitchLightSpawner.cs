using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLightSpawner : MonoBehaviour
{
    [SerializeField] private LEDLight lightPrefab;
    [SerializeField] private LightButton buttonPrefab;

    [Header("Light Color")]
    [SerializeField] private Color lightOnColor;
    [SerializeField] private Color lightOffColor;

    private LEDLight currentLight;


    public void SpawnLightAndSwitch(LightCommandInvoker commandInvoker)
    {
        if (commandInvoker != null)
        {
            currentLight = Instantiate(lightPrefab);
            LightButton currentButton = Instantiate(buttonPrefab);

            SetParent(currentLight, currentButton);
            currentLight.InitializeData(lightOnColor, lightOffColor);
            currentButton.InitializeButtonListener(commandInvoker, currentLight);
        }
    }

    private void SetParent(LEDLight currentLight, LightButton currentButton)
    {
        currentLight.transform.SetParent(transform, false);
        currentButton.transform.SetParent(transform, false);
    }

    public void SwitchOffLight()
    {
        currentLight.switchOffLight();
    }
}
