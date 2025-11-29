namespace Pattern.Gof.AbstractFactory;

public class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return new ProductB1();
    }
}