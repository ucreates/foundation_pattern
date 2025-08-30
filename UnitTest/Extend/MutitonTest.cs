using Pattern;
using Pattern.Extend;

namespace UnitTest.Extend;

public class MutitonTest
{
    [Test]
    public void InstanceTest()
    {
        CallGraph.GetInstance().Initialize();
        CallGraph.GetInstance().Enter();
        Assert.That(Multiton.InstanceDictionary?.Count ?? 0, Is.Zero);
        Multiton.GetInstance(Multiton.Category.Default).Execute();
        Assert.That(Multiton.InstanceDictionary.Count, Is.EqualTo(1));
        Assert.That(Multiton.HasInstance(Multiton.Category.Default), Is.True);
        var instance1 = Multiton.GetInstance(Multiton.Category.Default);
        var instance2 = Multiton.GetInstance(Multiton.Category.Cache);
        Assert.That(instance1, !Is.SameAs(instance2));
        Assert.That(Multiton.InstanceDictionary?.Count ?? 0, Is.EqualTo(2));
        CallGraph.GetInstance().Leave();
        CallGraph.GetInstance().Flush();
    }
}