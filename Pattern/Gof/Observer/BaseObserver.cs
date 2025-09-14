namespace Pattern.Gof.Observer;

public abstract class BaseObserver
{
    public string Name { get; set; } = string.Empty;
    public BaseObserverSubject ObserverSubject { get; private set; } = null;

    public void Attach(BaseObserverSubject observerSubject)
    {
        CallGraph.GetInstance().Enter();
        this.ObserverSubject = observerSubject;
        CallGraph.GetInstance().Leave();
    }

    public abstract void Update();
}