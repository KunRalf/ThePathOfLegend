using Player.Interfaces;
using Player.StateMachine;
using Services.Input;
using UnityEngine;

namespace Player
{
    public class PlayerMove : IUpdatableState
    {
        private readonly Rigidbody _rigidbody;
        private readonly Camera _camera;
        private readonly float _moveSpeed;
        private readonly float _rotateSpeed = 0.5f;
        private readonly float _gravity = 0.05f;
        private readonly Transform _transform;

        private Ray _ray;
        private readonly IInputControlService _inputControlService;
        
        
        public PlayerMove(Rigidbody rigidbody, Camera camera, float moveSpeed, IInputControlService inputControlService)
        {
            _inputControlService = inputControlService;
            _rigidbody = rigidbody;
            _transform = rigidbody.GetComponent<Transform>();
            _camera = camera;
            _moveSpeed = moveSpeed;
        }

        public void Update()
        {
            HandleMovement();
        }
        
        public void Enter()
        {
            
        }

        public void Exit()
        {
           
        }
        
        private void HandleMovement()
        {
            Vector3 movementVector = Vector3.zero;
            if (_inputControlService.Axis.sqrMagnitude > 0.02f)
            {
                movementVector = _camera.transform.TransformDirection(_inputControlService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();
                _transform.forward = movementVector;
                // _playerAnimator.Move(true);
            }
            else
            {
                // _playerAnimator.Move(false);
            }

            if (Vector3.Angle(_transform.forward, movementVector) > 1)
            {
                Vector3 moveDirection = Vector3.RotateTowards(_transform.forward, movementVector, _rotateSpeed, 0.0f);
                _transform.rotation = Quaternion.LookRotation(moveDirection);
            }
            _rigidbody.velocity = new Vector3(movementVector.x * _moveSpeed, _rigidbody.velocity.y - _gravity,
                movementVector.z * _moveSpeed);
        }

      

    }
}