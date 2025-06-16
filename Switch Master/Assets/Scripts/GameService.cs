using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameService : MonoBehaviour
{
    public static GameService instance;

    [SerializeField] private SwitchLightSpawner[] switchLightContainer;
    [SerializeField] private Button undoButton;
    [SerializeField] private Button redoButton;

    private LightCommandInvoker commandInvoker;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        commandInvoker = new LightCommandInvoker();
        undoButton.onClick.AddListener(UndoCommand);
        redoButton.onClick.AddListener(RedoCommand);

        for (int i = 0; i < switchLightContainer.Length; i++)
        {
            switchLightContainer[i].SpawnLightAndSwitch(commandInvoker);
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

}
