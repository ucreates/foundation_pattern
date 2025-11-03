using Pattern;
using Pattern.Gof.Adapter;
using Pattern.Gof.Bridge;

namespace UnitTest.Gof;

public class BridgeTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var abstraction = new RefinedAbstraction();
        abstraction.Implementor = new ConcreteImplementorA();
        abstraction.Execute();
        abstraction.Implementor = new ConcreteImplementorB();
        abstraction.Execute();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}