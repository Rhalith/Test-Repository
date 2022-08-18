using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GameManaging
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }
}