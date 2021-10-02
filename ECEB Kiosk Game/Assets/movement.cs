using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")) {
            rb.AddForce(100 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-100 * Time.deltaTime, 0, 0);
        }
    }
}
