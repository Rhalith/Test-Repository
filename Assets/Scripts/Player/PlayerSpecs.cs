using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerSpecs : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _shootingSpeed;
        [SerializeField] private int _arrowCapacity;
        [SerializeField] private float _incomeAmount;

        private float _localMoveSpeed;

        public float MoveSpeed { get => _moveSpeed; private set => _moveSpeed = value; }
        public float ShootingSpeed { get => _shootingSpeed; private set => _shootingSpeed = value; }
        public int ArrowCapacity { get => _arrowCapacity; private set => _arrowCapacity = value; }
        public float IncomeAmount { get => _incomeAmount; private set => _incomeAmount = value; }

        private void Start()
        {
            _localMoveSpeed = MoveSpeed;
            MoveSpeed = 0;
        }

        public void IncreaseShootingSpeed(float ratio)
        {
            ShootingSpeed *= ratio;
        }

        public void IncreaseIncome(float ratio)
        {
            IncomeAmount *= ratio;
        }

        public void IncreaseArrowCapacity(int amount)
        {
            ArrowCapacity += amount;
        }

        public void ResetMoveSpeed()
        {
            MoveSpeed = _localMoveSpeed;
        }
    }
}