using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Variables
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public Transform gC;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    void Update()
    {
        // Get input axis
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        // Move the player
        Vector3 movement = transform.right * xAxis + transform.forward * zAxis;
        controller.Move(movement * speed * Time.deltaTime);
    }
}
