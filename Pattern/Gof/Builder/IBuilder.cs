namespace Pattern.Gof.Builder;

public interface IBuilder
{
    public void AddElement(string element);
    public Product GetResult();
}