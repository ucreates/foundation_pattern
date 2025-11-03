namespace Pattern.Gof.State;

public interface IState
{
    public void Received(Context context);
}