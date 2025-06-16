using System.Collections.Generic;

public class LightCommandInvoker
{
    Stack<ICommand> lightToggleHistoryForUndo;
    Stack<ICommand> lightToggleHistoryForRedo;

    public LightCommandInvoker()
    {
        lightToggleHistoryForUndo = new Stack<ICommand>();
        lightToggleHistoryForRedo = new Stack<ICommand>();
    }

    public void ToggleLight(ICommand command)
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

    public void Replay()
    {


    }
}
