namespace Pattern.Gof;

public class Singleton
{
    private Singleton()
    {
    }

    public static Singleton? Instance { get; private set; }

    public static Singleton GetInstance()
    {
        Instance ??= new Singleton();
        return Instance;
    }

    public void Execute()
    {
    }
}