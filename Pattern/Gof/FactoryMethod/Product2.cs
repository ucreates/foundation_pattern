namespace Pattern.Gof.FactoryMethod;

public class Product2 : IProduct
{
    public string GetName()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return this.GetType().Name;
    }
}