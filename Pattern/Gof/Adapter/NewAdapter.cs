namespace Pattern.Gof.Adapter;

public class NewAdapter : AdapterTarget
{
    public void Request()
    {
        CallGraph.GetInstance().Enter();
        var adaptee = new Adaptee();
        adaptee.Execute();
        CallGraph.GetInstance().Leave();
    }
}