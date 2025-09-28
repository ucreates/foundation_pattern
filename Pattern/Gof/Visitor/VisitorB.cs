namespace Pattern.Gof;

public class VisitorB : BaseVisitor
{
    public override void VisitConcreteElementA(ElementA element)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"{element.GetType().Name} is visited by {this.GetType().Name}");
        CallGraph.GetInstance().Leave();
    }

    public override void VisitConcreteElementB(ElementB element)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"{element.GetType().Name} is visited by {this.GetType().Name}");
        CallGraph.GetInstance().Leave();
    }
}