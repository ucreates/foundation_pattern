namespace Pattern.Gof;

public class Singleton
{
    private Singleton()
    {
    }

    public static Singleton? Instance { get; private set; }

    public static Singleton GetInstance()
    {
        CallGraph.GetInstance().Enter();
        Instance ??= new Singleton();
        CallGraph.GetInstance().Leave();
        return Instance;
    }

    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}