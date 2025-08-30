namespace Pattern.Gof;

public abstract class BaseCommand
{
    public abstract bool CanExecute();
    public abstract void OnUndo(CommandParamter parameter);
    public abstract void OnRedo(CommandParamter parameter);
    public abstract void OnRollBack();
}