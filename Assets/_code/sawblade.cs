using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawblade : MonoBehaviour
{
   

    private void OnCollisionStay(Collision collision)
    {
        health otherObjectHealth = collision.other.GetComponent<health>();
        if (otherObjectHealth != null) {
            otherObjectHealth.takeDamage(1);
        }
    }
}
