namespace Pattern.Gof.Builder;

public class ConcreateBuilderA : IBuilder
{
    private Product Product { get; set; }

    public ConcreateBuilderA()
    {
        CallGraph.GetInstance().Enter();
        Product = new Product();
        Product.Statement = "Builded By Concreate Builder A";
        CallGraph.GetInstance().Leave();
    }

    public void AddElement(string element)
    {
        CallGraph.GetInstance().Enter();
        Product.Statement = $"{Product.Statement} {element} build By Concreate Builder A";
        CallGraph.GetInstance().Leave();
    }

    public Product GetResult()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return Product;
    }
}