namespace Pattern.Gof.Bridge;

public class RefinedAbstraction : BaseAbstraction
{
    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        Implementor.Execute();
        CallGraph.GetInstance().Leave();
    }
}