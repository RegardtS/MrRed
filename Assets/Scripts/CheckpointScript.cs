using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CheckpointScript : MonoBehaviour {

    public Transform _checkpointRoute;

    Transform _target;
    NavMeshAgent _agent;
    
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _target = _checkpointRoute.GetChild(0);
    }

    private void Update()
    {
        if (_agent.remainingDistance < 2)
        {
            _target = _checkpointRoute.GetChild(Random.Range(0, _checkpointRoute.childCount));
        }
        _agent.SetDestination(_target.position);
    }
}
