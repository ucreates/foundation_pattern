namespace Pattern.Gof;

public abstract class BaseVisitor
{
    public virtual void VisitConcreteElementA(ElementA element)
    {
    }

    public virtual void VisitConcreteElementB(ElementB element)
    {
    }
}