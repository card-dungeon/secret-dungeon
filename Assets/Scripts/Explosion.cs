using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 1000.0F;
    public float power = 100.0F;

    void Start()
    {

    }

    // void OnCollisionEnter(Collision other)
    // {
    //     Vector3 explosionPos = transform.position;
    //     Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
    //     foreach (Collider hit in colliders)
    //     {
    //         Rigidbody rb = hit.GetComponent<Rigidbody>();

    //         if (rb != null)
    //         {
    //             rb.AddExplosionForce(50f, new Vector3(0, 0.5f, 0), 100f, 50.0F);
    //             Debug.Log(1);
    //         }
    //     }
    // }

    // void OnMouseDown()
    // {
    //     GetComponent<Rigidbody>().AddForce(new Vector3(0, 10f, 0));
    //     GetComponent<Rigidbody>().angularVelocity = new Vector3(0.1f, 0.1f, 0.1f);
    // }
}
