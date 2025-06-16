using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameService : MonoBehaviour
{
    public static GameService instance;

    [SerializeField] private SwitchLightSpawner[] switchLightContainer;
    [SerializeField] private Button undoButton;
    [SerializeField] private Button redoButton;
    [SerializeField] private Button replayButton;

    [SerializeField] private float replayActionDelay;

    private LightCommandInvoker commandInvoker;
    private ReplayHandler replayHandler;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        commandInvoker = new LightCommandInvoker();
        undoButton.onClick.AddListener(UndoCommand);
        redoButton.onClick.AddListener(RedoCommand);
        replayButton.onClick.AddListener(StartReplay);

        replayHandler = new ReplayHandler();

        for (int i = 0; i < switchLightContainer.Length; i++)
        {
            switchLightContainer[i].SpawnLightAndSwitch(commandInvoker);
        }
    }

    private void Update()
    {

        if (replayHandler.IsReplaying())
        {
            replayHandler.ProcessReplay();
        }
    }

    public void UndoCommand()
    {
        commandInvoker.UndoCommand();
    }
    public void RedoCommand()
    {
        commandInvoker.RedoCommand();
    }

    public void StartReplay()
    {
        SwitchOffAllLights();

        replayHandler.SetReplayData(commandInvoker, replayActionDelay);
    }

    public void SwitchOffAllLights()
    {
        for (int i = 0; i < switchLightContainer.Length; i++)
        {
            switchLightContainer[i].SwitchOffLight();
        }
    }

    private void SetButtonInteraction(bool value)
    {
        undoButton.enabled = value;
        redoButton.enabled = value;
    }

    public void Reset()
    {
        SetButtonInteraction(true);
        commandInvoker.Reset();

    }

    public void PrintS(string val)
    {
        Debug.Log(val);
    }
}
