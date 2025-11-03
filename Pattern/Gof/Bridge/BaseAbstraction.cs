namespace Pattern.Gof.Bridge;

public abstract class BaseAbstraction
{
    public IImplementor Implementor { get; set; }

    public virtual void Execute()
    {
    }
}