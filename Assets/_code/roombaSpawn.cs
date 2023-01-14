using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roombaSpawn : MonoBehaviour
{
    public Transform[] spawnpos;
    public GameObject[] roombas;
    public float spawnGap;
    float nextSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && GameObject.FindGameObjectsWithTag("Roomba").Length<24) {
            Transform spawnPoint = spawnpos[Random.Range(0, spawnpos.Length)];
            Instantiate(roombas[Random.Range(0, roombas.Length)],spawnPoint.position,spawnPoint.rotation);
            nextSpawn = Time.time + spawnGap;
        }
    }
}
