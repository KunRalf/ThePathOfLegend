namespace Player.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IUpdatableState;
        void SwitchState<T>(IUpdatableState state) where T : IUpdatableState;
    }
}