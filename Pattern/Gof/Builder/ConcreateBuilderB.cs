namespace Pattern.Gof.Builder;

public class ConcreateBuilderB : IBuilder
{
    private Product Product { get; set; }

    public ConcreateBuilderB()
    {
        CallGraph.GetInstance().Enter();
        Product = new Product();
        Product.Statement = "Builded By Concreate Builder B";
        CallGraph.GetInstance().Leave();
    }

    public void AddElement(string element)
    {
        CallGraph.GetInstance().Enter();
        Product.Statement = $"{Product.Statement} {element} build By Concreate Builder B";
        CallGraph.GetInstance().Leave();
    }

    public Product GetResult()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return Product;
    }
}