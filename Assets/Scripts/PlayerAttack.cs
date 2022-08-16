using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField]
        void Start()
        {

        }


        private IEnumerator ShootEnemies(float shootingSpeed)
        {
            yield return new WaitForSeconds(shootingSpeed);
        }

        private void FireArrow()
        {

        }
    }
}