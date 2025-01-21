using System.Collections.Generic;
using System.Linq;
using Player.Interfaces;
using Services.Input;

namespace Player.StateMachine
{
    public class MovingStateMachine : IStateSwitcher, IUpdatable
    {
        private readonly PlayerController _playerController;
   
        private List<IUpdatableState> _states;
        private IUpdatableState _curState;
        
        public MovingStateMachine(PlayerController playerController, IInputControlService inputControlService)
        {
            _playerController = playerController;
            _states = new List<IUpdatableState>()
            {
                new PlayerMove(playerController.Rigidbody,playerController.Camera,playerController.MoveSpeed, inputControlService)
            };

            _curState = _states[0];
            _curState?.Enter();
        }

        public void SwitchState<T>() where T : IUpdatableState
        {
            IUpdatableState state = _states.FirstOrDefault(_ => _ is T);
            
            _curState?.Exit();
            _curState = state;
            _curState?.Enter();
        }

        public void SwitchState<T>(IUpdatableState state) where T : IUpdatableState
        {
            IUpdatableState curState = _states.FirstOrDefault(_ => _ is T);
            if (curState == default)
            {
                _states.Add(state);
            }
            else
            {
                _states.Remove(curState);
                _states.Add(state);
            }
            _curState?.Exit();
            _curState = state;
            _curState?.Enter();
        }

        public void Update() => _curState?.Update();
    }
}