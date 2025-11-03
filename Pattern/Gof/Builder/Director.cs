namespace Pattern.Gof.Builder;

public class Director
{
    private IBuilder Builder { get; set; }

    public Director(IBuilder builder)
    {
        CallGraph.GetInstance().Enter();
        Builder = builder;
        CallGraph.GetInstance().Leave();
    }

    public void Construct()
    {
        CallGraph.GetInstance().Enter();
        Builder.AddElement(this.GetType().Name);
        CallGraph.GetInstance().Leave();
    }
}