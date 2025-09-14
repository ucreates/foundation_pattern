namespace Pattern.Gof;

public class ProxySubject1 : IProxySubject
{
    public void Request()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}