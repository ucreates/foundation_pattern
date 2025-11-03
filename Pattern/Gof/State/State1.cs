namespace Pattern.Gof.State;

public class State1 : IState
{
    public void Received(Context context)
    {
        CallGraph.GetInstance().Enter();
        context.State = new State2();
        CallGraph.GetInstance().Leave();
    }
}