namespace Pattern.Gof.Observer;

public abstract class BaseObserver
{
    public string Name { get; set; } = string.Empty;
    public BaseSubject Subject { get; private set; } = null;

    public void Attach(BaseSubject subject)
    {
        CallGraph.GetInstance().Enter();
        this.Subject = subject;
        CallGraph.GetInstance().Leave();
    }

    public abstract void Update();
}