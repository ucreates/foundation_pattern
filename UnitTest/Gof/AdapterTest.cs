using Pattern;
using Pattern.Gof.Adapter;

namespace UnitTest.Gof;

public class AdapterTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        AdapterTarget adapter = new OldAdapter();
        adapter.Request();
        adapter = new NewAdapter();
        adapter.Request();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}