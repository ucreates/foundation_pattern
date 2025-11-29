namespace Pattern.Gof.AbstractFactory;

public class ProductB1 : AbstractProductB
{
    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}