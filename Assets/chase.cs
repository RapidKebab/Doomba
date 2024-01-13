using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] GameObject player;
    Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        updateTarget();
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((player.transform.position - playerPos).magnitude > 5) { 
            playerPos= player.transform.position;
            updateTarget();
        }
    }

    void updateTarget() {
        Debug.Log("did a thing");
        agent.destination = player.transform.position;
    }
}
