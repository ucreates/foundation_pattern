using Pattern;
using Pattern.Gof.Builder;

namespace UnitTest.Gof;

public class BuilderTest
{
    [Test]
    public void ConstructTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        IBuilder builder = new ConcreateBuilderA();
        var director = new Director(builder);
        director.Construct();
        var result = builder.GetResult();
        CallGraph.GetInstance().Log(result.Statement);
        Assert.That(result.Statement, Is.EqualTo("Builded By Concreate Builder A Director build By Concreate Builder A"));
        builder = new ConcreateBuilderB();
        director = new Director(builder);
        director.Construct();
        result = builder.GetResult();
        CallGraph.GetInstance().Log(result.Statement);
        Assert.That(result.Statement, Is.EqualTo("Builded By Concreate Builder B Director build By Concreate Builder B"));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}