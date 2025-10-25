namespace Pattern.Gof.Composite;

public class Leaf : Component
{
    public Leaf(string name)
    {
        this.Name = name;
    }

    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log(this.Name);
        CallGraph.GetInstance().Leave();
    }
}