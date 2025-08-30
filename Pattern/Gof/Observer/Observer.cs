namespace Pattern.Gof.Observer;

public class Observer : BaseObserver
{
    public Observer()
    {
    }

    public override void Update()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"{Name}'s current subject state is {this.Subject.State}");
        CallGraph.GetInstance().Leave();
    }
}