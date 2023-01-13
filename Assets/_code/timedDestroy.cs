using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedDestroy : MonoBehaviour
{
    public float destroyTime = 2 ;
    public GameObject destroyTarget;
    // Start is called before the first frame update
    void Start()
    {
        if (destroyTarget == null) { destroyTarget = this.gameObject; }
        Destroy(destroyTarget,destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
