namespace Pattern.Gof.Facade;

public class Facade
{
    public List<BaseSubSystem> SubSystemList { get; private set; } = new List<BaseSubSystem>();

    public void Open()
    {
        CallGraph.GetInstance().Enter();
        SubSystemList.ForEach(subSystem => { subSystem.Open(); });
        CallGraph.GetInstance().Leave();
    }

    public void Close()
    {
        CallGraph.GetInstance().Enter();
        SubSystemList.ForEach(subSystem => { subSystem.Open(); });
        CallGraph.GetInstance().Leave();
    }
}