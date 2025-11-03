namespace Pattern.Gof.State;

public class Context
{
    public IState State { get; set; }

    public Context(IState state)
    {
        this.State = state;
    }

    public void Request()
    {
        CallGraph.GetInstance().Enter();
        this.State.Received(this);
        CallGraph.GetInstance().Leave();
    }

    public void Display()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log(this.State.GetType().Name);
        CallGraph.GetInstance().Leave();
    }
}