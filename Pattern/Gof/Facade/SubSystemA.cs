namespace Pattern.Gof.Facade;

public class SubSystemA : BaseSubSystem
{
    public override void Open()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }

    public override void Close()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}