using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class FlyweightTest
{
    [Test]
    public void InstanceCountTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var keys = new string[] { "key1", "key2", "key3" };
        FlyweightFactory factory = new FlyweightFactory();
        Assert.That(factory.FlyweightDictionary.Count, Is.EqualTo(0));
        for (int i = 0; i < keys.Length; i++)
        {
            var flyweight = factory.GetFlyweight(keys[i]);
            flyweight.Excecute();
        }

        Assert.That(factory.FlyweightDictionary.Count, Is.EqualTo(keys.Length));
        for (int i = 0; i < keys.Length; i++)
        {
            var flyweight = factory.GetFlyweight(keys[i]);
            flyweight.Excecute();
        }

        Assert.That(factory.FlyweightDictionary.Count, Is.EqualTo(keys.Length));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}