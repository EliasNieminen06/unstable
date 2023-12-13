using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    // Variables
    public float sensitivity = 100f;
    public Transform player;
    float rotateX = 0f;

    private void Start()
    {
        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse movement axis
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate camera up and down and stop it in -90 and 90 so it cant go backwards
        rotateX -= mouseY;
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);

        // Rotate the player left and right
        transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
