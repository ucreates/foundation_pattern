namespace Pattern.Gof;

public class ObjectStructure
{
    public List<BaseElement> ElementList { get; set; } = new List<BaseElement>();

    public void Attatch(BaseElement element)
    {
        CallGraph.GetInstance().Enter();
        if (ElementList.Contains(element))
        {
            return;
        }

        ElementList.Add(element);
        CallGraph.GetInstance().Leave();
    }

    public void Detatch(BaseElement element)
    {
        CallGraph.GetInstance().Enter();
        if (!ElementList.Contains(element))
        {
            return;
        }

        ElementList.Remove(element);
        CallGraph.GetInstance().Leave();
    }

    public void Execute(BaseVisitor visitor)
    {
        CallGraph.GetInstance().Enter();
        ElementList.ForEach(element => { element.Excecute(visitor); });
        CallGraph.GetInstance().Leave();
    }
}