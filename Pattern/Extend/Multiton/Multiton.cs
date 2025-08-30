namespace Pattern.Extend;

public class Multiton
{
    public enum Category
    {
        Cache,
        Default,
    }

    public static Dictionary<Category, Multiton>? InstanceDictionary { get; set; } = new Dictionary<Category, Multiton>();

    private Multiton()
    {
    }

    public static Multiton GetInstance(Category category)
    {
        CallGraph.GetInstance().Enter();
        Multiton instance = null;
        if (!InstanceDictionary?.Any(pair => pair.Key == category) ?? false)
        {
            instance = new Multiton();
            InstanceDictionary.Add(category, instance);
        }
        else
        {
            instance = InstanceDictionary[category];
        }

        CallGraph.GetInstance().Leave();
        return instance;
    }

    public static bool HasInstance(Category category)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
        return null != InstanceDictionary?.FirstOrDefault(pair => pair.Key == category) ? true : false;
    }

    public void Execute()
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Leave();
    }
}