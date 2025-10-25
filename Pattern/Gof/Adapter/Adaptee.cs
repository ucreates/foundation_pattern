namespace Pattern.Gof.Adapter;

public class Adaptee
{
    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}