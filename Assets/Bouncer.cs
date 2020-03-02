using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    float bouncePower = 10;
    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();

        Vector3 bounce = Vector3.Reflect(pc.LastVelocity, collision.contacts[0].normal);

        Debug.Log("Velocity " + rb.velocity);
        Debug.Log("Bounce " + bounce);
        rb.AddForce(bounce.normalized * bouncePower);
    }
}
