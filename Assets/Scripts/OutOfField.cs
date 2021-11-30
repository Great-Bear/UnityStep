using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfField : MonoBehaviour {

	private GameObject spawnPosition;
	void Start () {
		spawnPosition = GameObject.Find("SpawnPosition");
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.gameObject.transform.parent.gameObject.name);

		other.gameObject.transform.parent.position = 
			spawnPosition.transform.position;

		other.gameObject.transform.parent.Translate(
			Vector2.up * Random.Range(-2f, 2f));
	}
}
