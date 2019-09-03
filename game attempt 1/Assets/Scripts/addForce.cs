using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public float thrust = 1.5F;
    public Rigidbody rb;
    public bool isTapable = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb);
    }

    private void OnTriggerEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        isTapable = true;
    }

    private void OnTriggerExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
        isTapable = false;
    }
    private void OnMouseDown()
    {
        if (isTapable)
        {
            Debug.Log("Tap!");

            rb.AddForce(transform.up * thrust);

            isTapable = false;
        }
        else
        {
            Debug.Log("Not tapable");
        }
    }
}
