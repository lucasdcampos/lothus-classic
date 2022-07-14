using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            Destroy(rb);
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Water"))
        {
            Destroy(gameObject);
        }
    }
}
