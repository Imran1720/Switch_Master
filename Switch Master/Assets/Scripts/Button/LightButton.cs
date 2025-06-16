using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightButton : MonoBehaviour
{
    private LEDLight targetLED;

    [SerializeField] private Button currentLEDButton;

    private LightCommandInvoker commandInvoker;

    public void InitializeButtonListener(LightCommandInvoker commandInvoker, LEDLight light)
    {
        this.commandInvoker = commandInvoker;
        targetLED = light;
        currentLEDButton.onClick.AddListener(ToggleLEDLight);
    }

    private void ToggleLEDLight()
    {
        ICommand command = new ToggleLightCommand(targetLED);
        commandInvoker.AddCommand(command);
    }
}
