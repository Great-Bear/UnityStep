using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public static float MoveVelocity = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveVelocity * Time.deltaTime);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.transform.parent.name.Equals("Bird"))
		{
            transform.Translate(Vector2.right * 20 + Vector2.up * Random.Range(-2.5f, 2.5f));
        }
		else if (collision.name.Equals("OutOfField"))
		{
            transform.Translate(Vector2.right * 25 + Vector2.up * Random.Range(-2.5f, 2.5f));
        }
		else
		{
            transform.Translate(Vector2.right);
        }
        if (Random.Range(0, 2) == 1)
        {
            Instantiate(gameObject, new Vector2(10, Random.Range(-2.5f, 2.5f)), Quaternion.identity);
        }
    }
}
