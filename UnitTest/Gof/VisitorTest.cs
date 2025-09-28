using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class VisitorTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var os = new ObjectStructure();
        os.Attatch(new ElementA());
        os.Attatch(new ElementB());
        var visitorA = new VisitorA();
        var visitorB = new VisitorB();
        os.Execute(visitorA);
        os.Execute(visitorB);
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}