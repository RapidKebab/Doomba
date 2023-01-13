using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform Muzzle;
    public GameObject Bullet;
    public float shotGap;
    float nextShot;
    //public bool playerControl;
    //public bool auto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    public void Shoot() {
        if (Time.time >= nextShot) {
            Instantiate(Bullet, Muzzle.position, Muzzle.rotation);
            nextShot = Time.time + shotGap;
        }
    }
}
