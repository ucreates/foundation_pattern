using Pattern;
using Pattern.Gof;
using Pattern.Gof.Composite;

namespace UnitTest.Gof;

public class CompositeTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var root = new Composite("root");
        root.Add(new Leaf("root1"));
        root.Add(new Leaf("root2"));
        var subA = new Composite("subA");
        subA.Add(new Leaf("subA-1"));
        subA.Add(new Leaf("subA-2"));
        root.Add(subA);
        var subB = new Composite("subB");
        subB.Add(new Leaf("subB-1"));
        subB.Add(new Leaf("subB-2"));
        root.Add(subB);
        root.Execute();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}