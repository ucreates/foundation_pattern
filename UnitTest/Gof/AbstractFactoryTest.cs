using Pattern;
using Pattern.Gof.AbstractFactory;

namespace UnitTest.Gof;

public class AbstractFactoryTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var factory = AbstractFactory.GetFactory(typeof(ConcreteFactory1));
        var productA = factory.CreateProductA();
        productA.Execute();
        Assert.That(productA.GetType(), Is.EqualTo(typeof(ProductA1)));
        var productB = factory.CreateProductB();
        productB.Execute();
        Assert.That(productB.GetType(), Is.EqualTo(typeof(ProductB1)));
        factory = AbstractFactory.GetFactory(typeof(ConcreteFactory2));
        productA = factory.CreateProductA();
        productA.Execute();
        Assert.That(productA.GetType(), Is.EqualTo(typeof(ProductA2)));
        productB = factory.CreateProductB();
        productB.Execute();
        Assert.That(productB.GetType(), Is.EqualTo(typeof(ProductB2)));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}