namespace Pattern.Gof.TemplateMethod;

public abstract class BaseTemplateMethod
{
    public virtual void Execute1()
    {
    }

    public virtual void Execute2()
    {
    }

    public virtual void Execute3()
    {
    }

    public void Run()
    {
        CallGraph.GetInstance().Enter();
        this.Execute1();
        this.Execute2();
        this.Execute3();
        CallGraph.GetInstance().Leave();
    }
}