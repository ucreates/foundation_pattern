using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class SingletonTest
{
    [Test]
    public void InstanceTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        Assert.That(Singleton.Instance, Is.Null);
        Singleton.GetInstance().Execute();
        Assert.That(Singleton.Instance, Is.Not.Null);
        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();
        Assert.That(instance1, Is.SameAs(instance2));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}