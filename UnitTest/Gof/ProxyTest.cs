using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class ProxyTest
{
    [Test]
    public void ChangeSubjectTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var proxy = new Proxy(1);
        proxy.Request();
        proxy = new Proxy(2);
        proxy.Request();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}