namespace Pattern.Gof.Bridge;

public class ConcreteImplementorB : IImplementor
{
    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}