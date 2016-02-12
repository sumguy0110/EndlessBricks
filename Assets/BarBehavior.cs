using UnityEngine;
using System.Collections;

public class BarBehavior : MonoBehaviour
{
    public float barSpeed = 10f;

    Rigidbody2D bar;

	// Use this for initialization
	void Start ()
    {
        bar = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Going Left");
            transform.Translate(Vector2.left * barSpeed * Time.deltaTime, Space.Self);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Going Right");
            transform.Translate(Vector2.right * barSpeed * Time.deltaTime, Space.Self);
        }
    }
}
