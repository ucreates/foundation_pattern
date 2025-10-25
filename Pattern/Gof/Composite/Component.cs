namespace Pattern.Gof.Composite;

public abstract class Component
{
    public string Name { get; set; }

    public virtual void Execute()
    {
    }
}