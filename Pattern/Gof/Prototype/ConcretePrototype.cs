namespace Pattern.Gof.Prototype;

public class ConcretePrototype : IPrototype
{
    public string Name { get; set; } = string.Empty;

    public IPrototype Clone()
    {
        CallGraph.GetInstance().Enter();
        var prototype = new ConcretePrototype();
        prototype.Name = this.Name;
        CallGraph.GetInstance().Leave();
        return prototype;
    }
}