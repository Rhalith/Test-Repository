using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private PlayerSpecs _playerSpecs;
        [SerializeField] private int _shootingRatio;
        [SerializeField] private GameObject _arrowPrefab;
        [SerializeField] private float _arrowSpeed;
        private Coroutine _shootCoroutine;

        public void StartShooting()
        {
            _playerSpecs.ResetMoveSpeed();
            _shootCoroutine = StartCoroutine(ShootEnemies(_playerSpecs.ShootingSpeed, _shootingRatio));
        }

        public void StopShooting()
        {
            StopCoroutine(_shootCoroutine);
        }

        private IEnumerator ShootEnemies(float shootingSpeed, float ratio)
        {
            while (true)
            {
                yield return new WaitForSeconds(ratio / shootingSpeed);
                FireArrow();
            }
        }

        private void FireArrow()
        {
            GameObject arrow = Instantiate(_arrowPrefab);
            arrow.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.75f);
            arrow.GetComponent<Rigidbody>().AddForce(Vector3.forward * _arrowSpeed * 100, ForceMode.Force);
        }
    }
}