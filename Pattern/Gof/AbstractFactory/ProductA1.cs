namespace Pattern.Gof.AbstractFactory;

public class ProductA1 : AbstractProductA
{
    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}