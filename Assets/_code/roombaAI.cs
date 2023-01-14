using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class roombaAI : MonoBehaviour
{
    Transform goal;
    NavMeshAgent agent;

    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    private void Update()
    {
        if(Vector3.Distance(agent.destination, goal.position)>0.1)
            agent.destination = goal.position;
    }
}
