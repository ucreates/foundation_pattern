namespace Pattern.Gof.Interpreter;

public class Expression1 : BaseExpression
{
    public override void Interpret(Context context)
    {
        CallGraph.GetInstance().Enter();
        CallGraph.GetInstance().Log($"use {context.Body}");
        CallGraph.GetInstance().Leave();
    }
}