namespace Pattern.Gof;

public class Colleagure : BaseColleagure
{
    public override void OnRequest(string message)
    {
        CallGraph.GetInstance().Enter();
        this.Mediator.OnNotify(message, this);
        CallGraph.GetInstance().Leave();
    }

    public override void OnReceive(string message)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"Colleagure {this.Id} Received Message: {message}");
        CallGraph.GetInstance().Leave();
    }
}