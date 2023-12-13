using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 movement;
    public float speed;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        speed = 2;
    }
    
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }
}
