using Pattern;
using Pattern.Gof.Observer;

namespace UnitTest.Gof;

public class ObserverTest
{
    [Test]
    public void AttachNotifyObserversTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var subject = new Subject();
        for (int i = 0; i < 5; i++)
        {
            var observer = new Observer()
            {
                Name = $"Observer{i + 1}",
            };
            subject.Attach(observer);
            observer.Attach(subject);
        }

        subject.State = "Default";
        subject.NotifyObservers();
        subject.State = "New";
        subject.NotifyObservers();
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }

    [Test]
    public void DetachNotifyObserversTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var subject = new Subject();
        for (int i = 0; i < 5; i++)
        {
            var observer = new Observer()
            {
                Name = $"Observer{i + 1}",
            };
            subject.Attach(observer);
            observer.Attach(subject);
        }

        //attach直後のNotifyObservers
        subject.State = "Default";
        subject.NotifyObservers();
        subject.State = "New";
        subject.NotifyObservers();
        //detachしながらNotifyObservers
        for (int i = 0; i < 5; i++)
        {
            var observer = subject.ObserverList[0];
            subject.Detach(observer);
            subject.State = "Default";
            subject.NotifyObservers();
            subject.State = "New";
            subject.NotifyObservers();
        }

        Assert.That(subject.ObserverList.Count, Is.EqualTo(0));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }

    [Test]
    public void AsyncNotifyObserversTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        var subject = new Subject();
        for (int i = 0; i < 5; i++)
        {
            var observer = new Observer()
            {
                Name = $"Observer{i + 1}",
            };
            subject.Attach(observer);
            observer.Attach(subject);
        }

        subject.State = "Default";
        subject.AsyncNotifyObservers();
        subject.State = "New";
        subject.AsyncNotifyObservers();
        subject.State = "Default";
        subject.AsyncNotifyObservers(true);
        subject.State = "New";
        subject.AsyncNotifyObservers(true);
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}