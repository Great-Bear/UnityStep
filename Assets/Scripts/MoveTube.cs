using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTube : MonoBehaviour
{
    public static float MoveVelocity = 2f;
    public static float GapSize = 2;

    private GameObject TopPart;
    private GameObject BottomPart;

    void Start()
    {
        TopPart = transform.Find("Top").gameObject;
        BottomPart = transform.Find("Bottom").gameObject;
    } 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveVelocity * Time.deltaTime);
    }

	void LateUpdate()
	{
		if(TopPart.transform.localPosition.y != GapSize)
		{
            TopPart.transform.localPosition = new Vector2(TopPart.transform.localPosition.x, GapSize);
            BottomPart.transform.localPosition = new Vector2(BottomPart.transform.localPosition.x, -GapSize);
        }
	}
}
