namespace Pattern.Gof.AbstractFactory;

public class ProductA2 : AbstractProductA
{
    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}