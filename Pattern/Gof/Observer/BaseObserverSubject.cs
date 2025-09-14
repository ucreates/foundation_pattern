namespace Pattern.Gof.Observer;

public abstract class BaseObserverSubject
{
    public string State { get; set; } = string.Empty;
    public List<BaseObserver> ObserverList { get; private set; } = new List<BaseObserver>();

    public void Attach(BaseObserver observer)
    {
        CallGraph.GetInstance().Enter();
        if (!ObserverList.Contains(observer))
        {
            CallGraph.GetInstance().Log($"attach {observer.Name}");
            ObserverList.Add(observer);
        }

        CallGraph.GetInstance().Leave();
    }

    public void Detach(BaseObserver observer)
    {
        CallGraph.GetInstance().Enter();
        if (ObserverList.Contains(observer))
        {
            CallGraph.GetInstance().Log($"dettach {observer.Name}");
            ObserverList.Remove(observer);
        }

        CallGraph.GetInstance().Leave();
    }

    public void NotifyObservers()
    {
        CallGraph.GetInstance().Enter();
        ObserverList.ForEach(observer => observer.Update());
        CallGraph.GetInstance().Leave();
    }

    public async void AsyncNotifyObservers(bool wait = false)
    {
        var task = Task.Run(() =>
        {
            CallGraph.GetInstance().Enter();
            ObserverList.ForEach(observer => observer.Update());
            CallGraph.GetInstance().Leave();
        });
        if (wait)
        {
            task.Wait();
        }

        await task;
    }
}