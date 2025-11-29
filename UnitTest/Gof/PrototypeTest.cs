using Pattern;
using Pattern.Gof;
using Pattern.Gof.Prototype;

namespace UnitTest.Gof;

public class PrototypeTest
{
    [Test]
    public void ChangeSubjectTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var prototype1 = new ConcretePrototype();
        var prototype2 = new ConcretePrototype();
        prototype1.Name = "Test1";
        prototype2.Name = "Test2";
        var prototypeList = new List<IPrototype>();
        for (int i = 0; i < 10; i++)
        {
            var prototype = i % 2 == 0 ? prototype1 : prototype2;
            var newPrototype = (ConcretePrototype)prototype.Clone();
            prototypeList.Add(newPrototype);
            newPrototype.Name = $"Test{i}";
        }

        prototypeList.ForEach(prototype => { CallGraph.GetInstance().Log((prototype as ConcretePrototype).Name); });
        Assert.That(prototype1.Name, Is.EqualTo("Test1"));
        Assert.That(prototype2.Name, Is.EqualTo("Test2"));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}