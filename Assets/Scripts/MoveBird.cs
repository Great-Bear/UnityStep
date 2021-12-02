using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBird : MonoBehaviour
{
    private float SpaceMagnitude = 200;
    private float UpArrowMagnitude = 700;
    private float score;
    private int lifes;

    private Rigidbody2D bird;
    private GameObject upperBound;
    private GameObject bottomBound;
    private Text textScore;
    private Text life;

    void Start()
    {
        lifes = 3;
        bird = GetComponent<Rigidbody2D>();
        upperBound = GameObject.Find("OutUp");
        bottomBound = GameObject.Find("OutDown");
        textScore = GameObject.Find("Score")
            .GetComponent<Text>();
        life = GameObject.Find("TextLife")
            .GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        life.text = lifes.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.AddForce(Vector2.up * SpaceMagnitude);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
		{
            bird.AddForce(Vector2.up * UpArrowMagnitude * Time.deltaTime);
		}

        if(lifes == 0)
		{
            GameObject.Find("MenuCanvas")
                   .GetComponent<MenuController>()
                   .ShowUserMenu();
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            GameObject.Find("MenuCanvas")
                .GetComponent<MenuController>()
                .ShowUserMenu();
            lifes--;
            // ~ Closest("Tube")
            GameObject tube = collision.gameObject;
			while(!tube.tag.Equals("Tube") && tube != null)
			{
                tube = tube.transform.parent?.gameObject;
			}
            this.transform.position = new Vector2(this.transform.position.x, tube.transform.position.y);
            bird.velocity = bird.velocity.normalized;
        }
        else if (collision.gameObject.name.Equals("OutUp"))
		{
            this.transform.position = new Vector2(bottomBound.transform.position.x, bottomBound.transform.position.y + 2);
        }
        else if (collision.gameObject.name.Equals("OutDown"))
		{
            this.transform.position = new Vector2(upperBound.transform.position.x, upperBound.transform.position.y - 2);
        }
        else if (collision.gameObject.tag.Equals("Tube"))
		{
            score += MoveTube.MoveVelocity + (4 - MoveTube.GapSize);
            textScore.text = score.ToString();
		}
        else if(collision.gameObject.tag.Equals("Egg"))
		{
            lifes++;
        }
    }
}
