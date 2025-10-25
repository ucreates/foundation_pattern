namespace Pattern.Gof.Adapter;

public class Adapton
{
    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}