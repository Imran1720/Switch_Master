
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReplayHandler
{
    private float actionDelay;
    private float timer;

    private bool isReplaying;

    private LightCommandInvoker commandInvoker;

    private Stack<ICommand> CommandsToBePlayed;

    public void SetReplayData(LightCommandInvoker commandInvoker, float actionDelay)
    {
        this.commandInvoker = commandInvoker;
        this.actionDelay = actionDelay;
        timer = actionDelay;
        SetUpReferences(commandInvoker);
        isReplaying = true;
    }

    private void SetUpReferences(LightCommandInvoker commandInvoker)
    {
        commandInvoker.SetUpReplayData();
        CommandsToBePlayed = new Stack<ICommand>(commandInvoker.GetReplayAction().Reverse());
    }

    public void ProcessReplay()
    {
        timer -= Time.deltaTime;
        if (CommandsToBePlayed.Count > 0 && timer <= 0)
        {
            commandInvoker.AddCommand(CommandsToBePlayed.Pop());
            timer = actionDelay;
            if (CommandsToBePlayed.Count <= 0) isReplaying = false;
        }
    }

    public bool IsReplaying() => isReplaying;
}

