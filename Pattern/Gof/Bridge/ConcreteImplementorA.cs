namespace Pattern.Gof.Bridge;

public class ConcreteImplementorA : IImplementor
{
    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}