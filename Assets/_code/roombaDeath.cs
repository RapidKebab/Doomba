using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roombaDeath : MonoBehaviour, death
{
    public GameObject deathObject;
    public void Die()
    {
        if(deathObject!=null)
            Instantiate(deathObject,this.transform.position,this.transform.rotation);
        Destroy(transform.root.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
