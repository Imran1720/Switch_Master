

public class ToggleLightCommand : ICommand
{
    private LEDLight currentLight;

    public ToggleLightCommand(LEDLight currentLight)
    {
        this.currentLight = currentLight;
    }

    public void Execute()
    {
        currentLight.ToggleLEDLight();
    }

    public void Redo()
    {
        currentLight.ToggleLEDLight();
    }

    public void Undo()
    {
        currentLight.ToggleLEDLight();
    }
}
