namespace Pattern.Gof;

public class Proxy : IProxySubject
{
    private IProxySubject ProxySubject { get; set; }

    public Proxy(int subjectId)
    {
        CallGraph.GetInstance().Enter();
        ProxySubject = subjectId == 1 ? new ProxySubject1() : new ProxySubject2();
        CallGraph.GetInstance().Leave();
    }

    public void Request()
    {
        CallGraph.GetInstance().Enter();
        ProxySubject.Request();
        CallGraph.GetInstance().Leave();
    }
}