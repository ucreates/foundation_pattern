namespace Pattern.Gof.State;

public class State2 : IState
{
    public void Received(Context context)
    {
        CallGraph.GetInstance().Enter();
        context.State = new State1();
        CallGraph.GetInstance().Leave();
    }
}