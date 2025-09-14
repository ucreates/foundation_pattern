namespace Pattern.Gof;

public class Mediator : BaseMediator
{
    public List<BaseColleagure> ColleagureList { get; private set; } = new List<BaseColleagure>();

    public override void OnNotify(string message, BaseColleagure colleagure)
    {
        CallGraph.GetInstance().Enter();
        if (ColleagureList.Contains(colleagure))
        {
            colleagure.OnReceive(message);
        }

        CallGraph.GetInstance().Leave();
    }
}