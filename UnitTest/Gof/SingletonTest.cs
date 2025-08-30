using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class SingletonTest
{
    [Test]
    public void InstanceTest()
    {
        Assert.That(Singleton.Instance, Is.Null);
        Singleton.GetInstance().Execute();
        Assert.That(Singleton.Instance, Is.Not.Null);
        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();
        Assert.That(instance1, Is.SameAs(instance2));
    }
}