using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent _navMeshAgent;
    private VariableDeclarations _declarations;
    public List<Vector3> patrolPoints;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _declarations = gameObject.GetComponent<Variables>().declarations;
    }

    private void FixedUpdate()
    {
    }

    void Update()
    {
        _declarations["DistanceToPlayer"] = (transform.position - player.transform.position).magnitude;
    }

    public void MoveToPlayer()
    {
        _navMeshAgent.SetDestination(player.transform.position);
    }

    public void MoveToLocation(Vector3 location)
    {
        _navMeshAgent.SetDestination(location);
    }

    public void StopMoving()
    {
        _navMeshAgent.SetDestination(transform.position);
    }
    
    // public IEnumerator 
}