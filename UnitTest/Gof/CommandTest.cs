using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class CommandTest
{
    [Test]
    public void ExecuteTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var param = new CommandParamter()
        {
            UndoValue = "UndoValue",
            RedoValue = "RedoValue"
        };
        var exector = new CommandExecuter()
        {
            CommandList = { new Command1(), new Command2() }
        };
        exector.Undo(param);
        exector.Redo(param);
        exector.RollBack();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}