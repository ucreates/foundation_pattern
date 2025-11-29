using Pattern;
using Pattern.Gof.FactoryMethod;

namespace UnitTest.Gof;

public class FactoryMethodTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var factory = new Factory();
        var product = factory.FactoryMethod(typeof(Product1));
        Assert.That(product.GetName(), Is.EqualTo(typeof(Product1).Name));
        product = factory.FactoryMethod(typeof(Product2));
        Assert.That(product.GetName(), Is.EqualTo(typeof(Product2).Name));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}