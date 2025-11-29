namespace Pattern.Gof.AbstractFactory;

public class ProductB2 : AbstractProductB
{
    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}