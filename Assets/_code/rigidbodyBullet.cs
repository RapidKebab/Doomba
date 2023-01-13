using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyBullet : MonoBehaviour
{
    public float forceForward=50;
    Rigidbody rb;
    public float damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(this.transform.forward * forceForward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit!");
        health otherObjectHealth = collision.other.GetComponentInParent<health>();
        if (otherObjectHealth != null)
        {
            otherObjectHealth.takeDamage(damage);
        }
        Destroy(this.gameObject);
    }
}
