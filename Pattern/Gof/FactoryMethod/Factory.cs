namespace Pattern.Gof.FactoryMethod;

public class Factory : IFactory
{
    public IProduct FactoryMethod(Type type)
    {
        CallGraph.GetInstance().Enter();
        IProduct result = null;
        if (type == typeof(Product1))
        {
            result = new Product1();
        }
        else if (type == typeof(Product2))
        {
            result = new Product2();
        }

        CallGraph.GetInstance().Leave();
        return result;
    }
}