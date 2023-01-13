using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawblade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        health otherObjectHealth = collision.other.GetComponent<health>();
        if (otherObjectHealth != null) {
            otherObjectHealth.takeDamage(1);
        }
    }
}
