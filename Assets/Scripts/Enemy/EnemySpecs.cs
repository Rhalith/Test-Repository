using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class EnemySpecs : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _health;
        private float _localMoveSpeed; // if freeze arrow accurs

        private void Awake()
        {
            _localMoveSpeed = MoveSpeed;
        }
        public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
        public float LocalMoveSpeed { get => _localMoveSpeed; private set => _localMoveSpeed = value; }
        public float Health { get => _health; set => _health = value; }
    }
}