namespace Pattern.Gof.AbstractFactory;

abstract public class AbstractFactory
{
    public virtual AbstractProductA CreateProductA()
    {
        return null;
    }

    public virtual AbstractProductB CreateProductB()
    {
        return null;
    }

    public static AbstractFactory GetFactory(Type type)
    {
        CallGraph.GetInstance().Enter();
        AbstractFactory factory = null;
        if (type == typeof(ConcreteFactory1))
        {
            factory = new ConcreteFactory1();
        }
        else if (type == typeof(ConcreteFactory2))
        {
            factory = new ConcreteFactory2();
        }

        CallGraph.GetInstance().Leave();
        return factory;
    }
}