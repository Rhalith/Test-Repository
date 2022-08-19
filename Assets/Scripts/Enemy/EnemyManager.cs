using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private EnemyMovement _enemyMovement;
        [SerializeField] private EnemySpecs _enemySpec;
        [SerializeField] private Animator _animator;
        [SerializeField] private ParticleSystem _particleSystem;
        [SerializeField] private SkinnedMeshRenderer _meshRenderer;

        private void Start()
        {
            _enemyMovement.Agent.speed = _enemySpec.MoveSpeed;
            _animator.speed = _enemySpec.MoveSpeed;
        }

        /// <summary>
        /// minus for decrease, plus for increase
        /// </summary>
        /// <param name="ratio"></param>
        public void ChangeEnemySpeed(float ratio)
        {
            _enemySpec.MoveSpeed *= ratio;
            _enemyMovement.Agent.speed = _enemySpec.MoveSpeed;
            _animator.speed = _enemySpec.MoveSpeed;
        }

        public void ResetEnemySpeed()
        {
            _enemySpec.MoveSpeed = _enemySpec.LocalMoveSpeed;
            _enemyMovement.Agent.speed = _enemySpec.MoveSpeed;
            _animator.speed = _enemySpec.MoveSpeed;
        }

        public void KillEnemy()
        {
            _collider.enabled = false;
            ChangeEnemySpeed(0);
            _meshRenderer.enabled = false;
            _particleSystem.Play();
            Invoke("DestroyEnemy", 1.2f);
        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
        }
    }
}