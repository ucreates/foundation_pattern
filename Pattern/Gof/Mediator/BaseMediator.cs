namespace Pattern.Gof;

public abstract class BaseMediator
{
    public abstract void OnNotify(string message, BaseColleagure colleagure);
}