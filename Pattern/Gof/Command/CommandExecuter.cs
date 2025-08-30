namespace Pattern.Gof;

public class CommandExecuter
{
    public List<BaseCommand> CommandList { get; private set; } = new List<BaseCommand>();

    public void Undo(CommandParamter paramter)
    {
        CallGraph.GetInstance().Enter();
        CommandList.ForEach(command =>
        {
            if (!command.CanExecute())
            {
                return;
            }

            command.OnUndo(paramter);
        });
        CallGraph.GetInstance().Leave();
    }

    public void Redo(CommandParamter paramter)
    {
        CallGraph.GetInstance().Enter();
        CommandList.ForEach(command =>
        {
            if (!command.CanExecute())
            {
                return;
            }

            command.OnRedo(paramter);
        });
        CallGraph.GetInstance().Leave();
    }

    public void RollBack()
    {
        CallGraph.GetInstance().Enter();
        CommandList.ForEach(command =>
        {
            if (!command.CanExecute())
            {
                return;
            }

            command.OnRollBack();
        });
        CallGraph.GetInstance().Leave();
    }
}