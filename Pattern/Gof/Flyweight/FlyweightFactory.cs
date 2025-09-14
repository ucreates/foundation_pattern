namespace Pattern.Gof;

public class FlyweightFactory
{
    public Flyweight GetFlyweight(string key)
    {
        CallGraph.GetInstance().Enter();
        if (!FlyweightDictionary.ContainsKey(key))
        {
            CallGraph.GetInstance().Log($"add flyweight key={key}");
            FlyweightDictionary.Add(key, new Flyweight());
        }

        CallGraph.GetInstance().Leave();
        return FlyweightDictionary[key];
    }

    public Dictionary<string, Flyweight> FlyweightDictionary { get; private set; } = new Dictionary<string, Flyweight>();
}