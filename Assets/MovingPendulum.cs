using UnityEngine;

public class MovingPendulum : MonoBehaviour
{
    Vector2 direction = new Vector2(3,0);
    const float speed = 0.01f;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, direction, speed);
        if(transform.position.x == direction.x)
        {
            direction = -direction;
        }
    }
}
