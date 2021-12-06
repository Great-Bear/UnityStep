using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float AddZPos = 0;
    public float AddYPos = 0;

    void LateUpdate()
    {        
        if (target != null)
        {
            Vector3 newPosition = transform.position;

            newPosition.x = target.position.x;

            newPosition.z = target.position.z - AddZPos;
            newPosition.y = target.position.y + AddYPos;

            transform.position = newPosition;
        }
    }
}
