using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    public Transform cam;
    public Transform attackPoint;
    public GameObject lager;
    public int totalThrows;
    public float throwCooldown;
    public float throwForce;
    public float throwUpwardForce;
    bool readyToThrow;
    // Start is called before the first frame update
    void Start()
    {
        readyToThrow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && readyToThrow && totalThrows > 0)
        {
            Throw();
        }
    }

    void Throw()
    {
        readyToThrow = false;
        GameObject projectile = Instantiate(lager, attackPoint.position, cam.rotation);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        Vector3 forceDirection = cam.transform.forward;
        RaycastHit hit;
        if(Physics.Raycast(cam.position, cam.forward, out hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;
        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);
        totalThrows--;
        Invoke(nameof(ResetThrow), throwCooldown);
    }
    void ResetThrow()
    {
        readyToThrow = true;
    }
}
