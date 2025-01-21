using System;
using System.Collections.Generic;
using Player.Interfaces;
using Player.StateMachine;
using Services.Input;
using UnityEngine;
using Zenject;


namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [field:SerializeField] public float MoveSpeed { get; private set; }
        public Camera Camera { get; private set; }
        public Rigidbody Rigidbody { get; private set; }

        private MovingStateMachine _movingStateMachine;
        private IInputControlService _inputControllService;

        [Inject]
        public void Construct(IInputControlService inputControlService)
        {
            _inputControllService = inputControlService;
        }

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
            Camera = Camera.main;

            _movingStateMachine = new MovingStateMachine(this,_inputControllService);
        }
        
        private void FixedUpdate()
        {
            _movingStateMachine?.Update();
        }

        public void SwitchState<T>(IUpdatableState state) where T : IUpdatableState
        {
            _movingStateMachine.SwitchState<T>(state);
        }
        public void SwitchState<T>() where T : IUpdatableState
        {
            _movingStateMachine.SwitchState<T>();
        }
       
    }
}