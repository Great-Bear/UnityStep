using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfField : MonoBehaviour
{
    private GameObject spawnPosition;
    void Start()
    {
        spawnPosition = GameObject.Find("SpawnPosition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Tube"))
        {
            //Debug.Log(collision.gameObject.transform.gameObject.name);
            collision.gameObject.transform.position = spawnPosition.transform.position;
            collision.gameObject.transform.Translate(Vector2.up * Random.Range(-2f, 2f));
        }
    }
}
