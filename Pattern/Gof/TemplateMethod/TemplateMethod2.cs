namespace Pattern.Gof.TemplateMethod;

public class TemplateMethod2 : BaseTemplateMethod
{
    public override void Execute1()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }

    public override void Execute2()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }

    public override void Execute3()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}