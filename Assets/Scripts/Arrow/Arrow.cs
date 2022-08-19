using Assets.Scripts.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Arrow
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Collider _collider;

        public Rigidbody Rigidbody { get => _rigidbody; }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                KillEnemy(collision);
                DestroyArrow();
            }
            else if (collision.collider.CompareTag("Obstacle"))
            {
                StopArrow();
            }
        }

        private void KillEnemy(Collision enemy)
        {
            enemy.gameObject.GetComponentInParent<EnemyManager>().KillEnemy();
        }

        private void StopArrow()
        {
            _rigidbody.velocity = Vector3.zero;
            Invoke("FreezeArrow", 0.1f);
            Invoke("DestroyArrow", 2f);
        }

        private void DestroyArrow()
        {
            Destroy(gameObject);
        }

        private void FreezeArrow()
        {
            _rigidbody.isKinematic = true;
            _collider.isTrigger = true;
        }
    }
}