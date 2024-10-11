using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStates : MonoBehaviour
{
    private EnemyController _enemyController;
    private List<Vector3> _patrol;
    private int _currentPatrolPointIndex;
    private NavMeshAgent _navMeshAgent;


    private void Start()
    {
        _enemyController = GetComponent<EnemyController>();
        _patrol = _enemyController.patrolPoints;
        _navMeshAgent = GetComponent<NavMeshAgent>();

    }

    public void DoAttackState()
    {
        Debug.Log("ARRR THIS IS A ATTACK!");
    }

    public void DoPatrolState()
    {
        if (_currentPatrolPointIndex.Equals(null)) return;

        var distanceToDestination = _patrol[_currentPatrolPointIndex] - transform.position;
        if (Math.Abs(distanceToDestination.x) < 0.1f && Math.Abs(distanceToDestination.z) < 0.1f)
        {
            _currentPatrolPointIndex++;
            if (_currentPatrolPointIndex == _patrol.Count)
            {
                _currentPatrolPointIndex = 0;
            }
        }

        _navMeshAgent.SetDestination(_patrol[_currentPatrolPointIndex]);
    }
    
    public void ExitPatrolState()
    {
        _enemyController.StopMoving();
    }
    
    public void EnterPatrolState()
    {
        if (_currentPatrolPointIndex.Equals(null))
        {
            _currentPatrolPointIndex = 0;
        }
    }

    public void DoFollowState()
    {
        _enemyController.MoveToPlayer();
    }

    public void ExitFollowState()
    {
        _enemyController.StopMoving();
    }
}