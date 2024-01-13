using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeffJump : MonoBehaviour
{
    [SerializeField]float jumpPower = 500;
    Rigidbody rb;
    Animator anim;
    AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        AS=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            AS.PlayOneShot(AS.clip);
            anim.SetTrigger("jump");
            rb.AddForce(gameObject.transform.up * jumpPower, ForceMode.Impulse);
        }
    }
}
