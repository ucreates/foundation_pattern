using Pattern;
using Pattern.Gof.Facade;

namespace UnitTest.Gof;

public class FacadeTest
{
    [Test]
    public void RunTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var facade = new Facade()
        {
            SubSystemList =
            {
                new SubSystemA(),
                new SubSystemB()
            }
        };
        facade.Open();
        facade.Close();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}