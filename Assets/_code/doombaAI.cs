using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doombaAI : MonoBehaviour
{
    public gun doombaGun;
    public LayerMask layers;
    // Start is called before the first frame update
    void Start()
    {
        doombaGun = GetComponentInChildren<gun>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 15f,layers))
        {
            if (hit.collider.gameObject.tag == "Player") {
                doombaGun.Shoot();
            }
        }
    }
}
