using TopDownShooter.Entities.Player;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        target = FindAnyObjectByType<Player>().transform;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
