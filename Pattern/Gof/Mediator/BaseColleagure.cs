namespace Pattern.Gof;

public abstract class BaseColleagure
{
    public int Id { get; set; } = 0;
    public Mediator Mediator { get; set; } = null!;
    public abstract void OnRequest(string message);
    public abstract void OnReceive(string message);
}