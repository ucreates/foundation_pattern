using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pattern;

public class CallGraph
{
    private class CallStack
    {
        public int Count { get; set; } = 0;
        public List<string> CallingList { get; set; } = new List<string>();
    }

    private Dictionary<int, CallStack> CallStackDictionary { get; set; } = new Dictionary<int, CallStack>();

    public int OutputLevel { get; private set; } = -1;

    public static CallGraph Instance { get; private set; }

    private CallGraph()
    {
    }

    public static CallGraph GetInstance()
    {
        Instance ??= new CallGraph();
        return Instance;
    }

    public void Enter()
    {
        CallStack callStack = null;
        var threadId = Thread.CurrentThread.ManagedThreadId;
        if (!CallStackDictionary.ContainsKey(threadId))
        {
            callStack = new CallStack();
            callStack.CallingList.Add($"```plantuml");
            callStack.CallingList.Add($"@startuml");
            callStack.CallingList.Add($"salt");
            callStack.CallingList.Add($"{{{{T");
            CallStackDictionary.Add(threadId, callStack);
        }
        else
        {
            callStack = CallStackDictionary[threadId];
            if (callStack.CallingList.Any(call => call.Equals("```")))
            {
                callStack.CallingList = callStack.CallingList.Take(callStack.CallingList.Count - 3).ToList();
            }
        }

        callStack = CallStackDictionary[threadId];
        callStack.Count += 1;
        if (-1 == OutputLevel || callStack.Count <= OutputLevel)
        {
            WriteLine($"<color:green><&account-login>[{threadId}/{callStack.Count}]</color>");
        }
    }

    public void Leave()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        if (!CallStackDictionary.ContainsKey(threadId))
        {
            return;
        }

        var callStack = CallStackDictionary[threadId];
        if (-1 == OutputLevel || callStack.Count <= OutputLevel)
        {
            WriteLine($"<color:Red><&account-logout>[{threadId}/{callStack.Count}]</color>");
        }

        callStack.Count -= 1;
        if (0 == callStack.Count)
        {
            callStack.CallingList.Add($"}}}}");
            callStack.CallingList.Add($"@enduml");
            callStack.CallingList.Add($"```");
        }
    }

    public void Log(string value)
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        if (!CallStackDictionary.ContainsKey(threadId))
        {
            return;
        }

        var callStack = CallStackDictionary[threadId];
        if (-1 == OutputLevel || callStack.Count <= OutputLevel)
        {
            WriteLine($"<color:gray><&info>[{threadId}/{callStack.Count}]</color>", value);
        }
    }

    public void Flush()
    {
        while (true)
        {
            var count = 0;
            foreach (var call in CallStackDictionary)
            {
                if (call.Value.CallingList.Any(log => log.Equals("```")))
                {
                    count++;
                }
            }

            if (count == CallStackDictionary.Count)
            {
                break;
            }
        }

        foreach (var call in CallStackDictionary)
        {
            call.Value.CallingList.ForEach(log => { Console.WriteLine(log); });
        }
    }

    public void Initialize()
    {
        OutputLevel = -1;
        CallStackDictionary.Clear();
    }

    public void SetOutputLevel(int level)
    {
        OutputLevel = level;
    }

    private void WriteLine(string header)
    {
        var frame = new StackFrame(2, true);
        var methodInfo = frame.GetMethod();
        var threadId = Thread.CurrentThread.ManagedThreadId;
        if (!CallStackDictionary.ContainsKey(threadId))
        {
            return;
        }

        var callStack = CallStackDictionary[threadId];
        callStack.CallingList.Add($"{new string('+', callStack.Count)}{header}:{methodInfo.ReflectedType.FullName}.{methodInfo.Name}");
    }

    private void WriteLine(string header, string value)
    {
        var frame = new StackFrame(2, true);
        var methodInfo = frame.GetMethod();
        var threadId = Thread.CurrentThread.ManagedThreadId;
        if (!CallStackDictionary.ContainsKey(threadId))
        {
            return;
        }

        var callStack = CallStackDictionary[threadId];
        callStack.CallingList.Add($"{new string('+', callStack.Count)}{header}:{methodInfo.ReflectedType.FullName}.{methodInfo.Name},<color:orange>{value}</color> in {frame.GetFileName()} at Line {frame.GetFileLineNumber()}");
    }
}