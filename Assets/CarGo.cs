using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//script to move AI Car around the track
public class CarGo : MonoBehaviour
{

    private GameObject targetGo = null;
    private CheckpointTracker checkpointTracker;
    private NavMeshAgent navMeshAgent;


    // Use this for initialization
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        checkpointTracker = GetComponent<CheckpointTracker>();
        HeadForNextWaypoint();

    }

    // Update is called once per frame
    void Update()
    {

        //float closeToDestination = NavMeshAgent.stoppingDistance * 2;
        //if (navMeshAgent.remainingDistance < closeToDestination)
        //{
        //HeadForNextWaypoint();
        //}
        // object reference is required for the non static field error on navMeshAgent.stoppingDistance * 2

    }

    private void HeadForNextWaypoint()
    {
        targetGo = checkpointTracker.NextCheckpoint(targetGo);
        navMeshAgent.SetDestination(targetGo.transform.position);
    }
}
