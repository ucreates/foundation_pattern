using System.Diagnostics;

namespace Pattern.Gof;

public class Command1 : BaseCommand
{
    public override bool CanExecute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return true;
    }

    public override void OnUndo(CommandParamter parameter)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"parameter::{parameter.UndoValue}");
        CallGraph.GetInstance().Leave();
    }

    public override void OnRedo(CommandParamter parameter)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"parameter::{parameter.RedoValue}");
        CallGraph.GetInstance().Leave();
    }

    public override void OnRollBack()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}