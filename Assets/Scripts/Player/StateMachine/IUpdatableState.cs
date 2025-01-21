namespace Player.StateMachine
{
    public interface IUpdatableState : IState
    {
        void Update();
    }
}