using Pattern;
using Pattern.Gof.State;

namespace UnitTest.Gof;

public class StateTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var context = new Context(new State1());
        context.Request();
        context.Display();
        context.Request();
        context.Display();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}