using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour
{

    public float verticalSpeed = 10f;
    public bool resetTrigger = true;

    Rigidbody2D ball;

	// Use this for initialization
	void Start ()
    {
        ball = GetComponent<Rigidbody2D>();
        Vector2 ballSpeed = new Vector2(0f, verticalSpeed);
        ball.AddForce((ballSpeed * Time.deltaTime), ForceMode2D.Impulse);
        
    }
	
	// Update is called once per frame
	void Update ()
    {

    }


    void BallStartSpeed()
    {
        Vector2 ballSpeed = new Vector2(0f, verticalSpeed);
        ball.AddForce(ballSpeed, ForceMode2D.Impulse);
    }

    
}
