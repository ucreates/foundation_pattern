namespace Pattern.Gof.FactoryMethod;

public interface IFactory
{
    public IProduct FactoryMethod(Type type);
}