using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_0 : MonoBehaviour {

	public float rotSpeed;
	public float maxRotSpeed = 100f;
	float currentRotation = 0f;

	void Update() {
		transform.Rotate( new Vector3( 0f, currentRotation * Time.deltaTime, 0f ) );

		currentRotation = Mathf.Min( currentRotation + Time.deltaTime * rotSpeed, maxRotSpeed );
	}
}
