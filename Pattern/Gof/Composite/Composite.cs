namespace Pattern.Gof.Composite;

public class Composite : Component
{
    private List<Component> ComponentList { get; set; } = new List<Component>();

    public Composite(string name)
    {
        this.Name = name;
    }

    public override void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log(this.Name);
        this.ComponentList.ForEach(component => component.Execute());
        CallGraph.GetInstance().Leave();
    }

    public void Add(Component component)
    {
        if (!this.ComponentList.Contains(component))
        {
            this.ComponentList.Add(component);
        }
    }

    public void Remove(Component component)
    {
        if (this.ComponentList.Contains(component))
        {
            this.ComponentList.Remove(component);
        }
    }

    public Component GetChild(int index)
    {
        if (this.ComponentList.Count <= index)
        {
            return null;
        }

        return this.ComponentList[index];
    }
}