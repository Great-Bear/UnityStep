using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float forceFactor = 200;

    private Vector3 forceDirection;
    private Rigidbody rb;
    void Start()
    {
        forceDirection = Vector3.zero;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forceDirection.x = Input.GetAxis("Horizontal");
        forceDirection.z = Input.GetAxis("Vertical");
        rb.AddForce(forceDirection * forceFactor * Time.deltaTime);
    }
}
