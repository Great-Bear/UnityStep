using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float forceFactor = 200;
    private Rigidbody rb;
    private GameObject focalPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(focalPoint.transform.forward * Input.GetAxis("Vertical") * 750 * Time.deltaTime);
    }
}
