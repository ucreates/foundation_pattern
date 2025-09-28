namespace Pattern.Gof;

public class ElementB : BaseElement
{
    public override void Excecute(BaseVisitor visitor)
    {
        CallGraph.GetInstance().Enter();
        visitor.VisitConcreteElementB(this);
        CallGraph.GetInstance().Leave();
    }
}