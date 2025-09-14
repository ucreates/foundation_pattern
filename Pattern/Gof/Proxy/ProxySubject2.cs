namespace Pattern.Gof;

public class ProxySubject2 : IProxySubject
{
    public void Request()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}