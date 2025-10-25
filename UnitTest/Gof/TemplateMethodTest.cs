using Pattern;
using Pattern.Gof.TemplateMethod;

namespace UnitTest.Gof;

public class TemplateMethodTest
{
    [Test]
    public void RunTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var templateMethodList = new List<BaseTemplateMethod>()
        {
            new TemplateMethod1(),
            new TemplateMethod2(),
        };
        templateMethodList.ForEach(templateMethod => { templateMethod.Run(); });
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}