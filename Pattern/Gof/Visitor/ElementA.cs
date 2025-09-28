namespace Pattern.Gof;

public class ElementA : BaseElement
{
    public override void Excecute(BaseVisitor visitor)
    {
        CallGraph.GetInstance().Enter();
        visitor.VisitConcreteElementA(this);
        CallGraph.GetInstance().Leave();
    }
}