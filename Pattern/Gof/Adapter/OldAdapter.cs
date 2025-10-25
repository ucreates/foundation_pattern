namespace Pattern.Gof.Adapter;

public class OldAdapter : AdapterTarget
{
    public void Request()
    {
        CallGraph.GetInstance().Enter();
        var adapton = new Adapton();
        adapton.Execute();
        CallGraph.GetInstance().Leave();
    }
}