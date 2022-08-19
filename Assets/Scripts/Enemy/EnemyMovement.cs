using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] List<Transform> _positions;
        [SerializeField] private NavMeshAgent _agent;

        public NavMeshAgent Agent { get => _agent; private set => _agent = value; }

        void Start()
        {
            int i = Random.Range(0, _positions.Count);
            Agent.SetDestination(_positions[i].position);
        }

    }
}