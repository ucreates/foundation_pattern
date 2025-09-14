namespace Pattern.Gof;

public class Flyweight
{
    public void Excecute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}