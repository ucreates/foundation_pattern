namespace Pattern.Gof.AbstractFactory;

public class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return new ProductB2();
    }
}