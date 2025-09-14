using Pattern;
using Pattern.Gof;

namespace UnitTest.Gof;

public class MediatorTest
{
    [Test]
    public void RequestTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var mediator = new Mediator();
        for (int i = 0; i < 2; i++)
        {
            var colleagure = new Colleagure()
            {
                Id = i + 1,
                Mediator = mediator
            };
            mediator.ColleagureList.Add(colleagure);
        }

        mediator.ColleagureList.ForEach(colleagure => { colleagure.OnRequest($"doesn't exist evidence to colleagure {colleagure.Id}"); });
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}