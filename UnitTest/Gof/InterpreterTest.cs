using Pattern;
using Pattern.Gof.Interpreter;

namespace UnitTest.Gof;

public class InterpreterTest
{
    [Test]
    public void InterpretTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var context = new Context();
        var expressionLit = new List<BaseExpression>()
        {
            new Expression1(),
            new Expression2()
        };
        expressionLit.ForEach(expression => { expression.Interpret(context); });
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}