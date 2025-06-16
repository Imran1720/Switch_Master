using System.Collections.Generic;
using UnityEngine;

public class LightCommandInvoker
{
    Stack<ICommand> lightToggleHistoryForUndo;
    Stack<ICommand> lightToggleHistoryForRedo;
    Stack<ICommand> replayCommandStack;

    public LightCommandInvoker()
    {
        lightToggleHistoryForUndo = new Stack<ICommand>();
        lightToggleHistoryForRedo = new Stack<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        command.Execute();
        lightToggleHistoryForUndo.Push(command);
    }

    public void UndoCommand()
    {
        if (lightToggleHistoryForUndo.Count > 0)
        {
            ICommand previousCommand = lightToggleHistoryForUndo.Pop();
            previousCommand.Undo();
            lightToggleHistoryForRedo.Push(previousCommand);
        }
    }
    public void RedoCommand()
    {
        if (lightToggleHistoryForRedo.Count > 0)
        {
            ICommand nextCommand = lightToggleHistoryForRedo.Pop();
            nextCommand.Redo();
            lightToggleHistoryForUndo.Push(nextCommand);
        }
    }

    public void SetUpReplayData()
    {
        replayCommandStack = new Stack<ICommand>(lightToggleHistoryForUndo);
    }

    public void Reset()
    {
        lightToggleHistoryForUndo.Clear();
        lightToggleHistoryForRedo.Clear();
        replayCommandStack.Clear();
    }

    public Stack<ICommand> GetReplayAction() => replayCommandStack;
}
