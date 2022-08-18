using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private PlayerSpecs _playerSpec;
        [SerializeField] private PlayerInput _playerInput;
        private InputAction _moveAction;
        public Vector2 _movement;

        private void Awake()
        { 
            _moveAction = _playerInput.actions["Move"];
        }

        public void MovementWithKeyboard()
        {
            var input = _moveAction.ReadValue<Vector2>();
            _movement.x = input.x;
        }

        private void FixedUpdate()
        {
            transform.Translate(_movement * _playerSpec.MoveSpeed / 10f, Space.World);
        }


    }
}