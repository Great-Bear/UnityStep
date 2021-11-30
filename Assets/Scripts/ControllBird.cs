using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBird : MonoBehaviour
{
    const ushort force = 4;
    Rigidbody2D _rb;
    Vector3 directionVertical;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * force, ForceMode2D.Impulse);
        }
        float VertialAxis = Input.GetAxisRaw("Vertical");

        if( VertialAxis > 0)
        {
            directionVertical = Vector3.up;
        }
        else if(VertialAxis < 0)
        {
            directionVertical = Vector3.down;
        }
        _rb.AddForce(directionVertical * force, ForceMode2D.Force); 
    }
}
