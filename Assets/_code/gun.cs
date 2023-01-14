using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform Muzzle;
    public GameObject Bullet;
    public float shotGap;
    float nextShot;
    public bool playerControl = true;
    public bool auto;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControl&&((Input.GetButtonDown("Fire1") && !auto)||(Input.GetButton("Fire1")&&auto))) {
            Shoot();
        }
    }

    public void Shoot() {
        
        if (Time.time >= nextShot) {
            Instantiate(Bullet, Muzzle.position, Muzzle.rotation);
            nextShot = Time.time + shotGap;
            if (anim != null) {
                anim.SetTrigger("shoot");
            }
        }
    }
}
