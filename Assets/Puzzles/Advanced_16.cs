using System;
using UnityEngine;
using System.Collections;

// What is being used in this script?  Why?

public class Advanced_15 : MonoBehaviour {

	Action<float> onComplete;

	float maxDistJumped = 0f;

	Vector3 startJumpPos = default(Vector3);

	void Update() {
		if( Input.GetKeyDown( KeyCode.Space ) ) {
			StartCoroutine( Jump( z => maxDistJumped = Mathf.Max(maxDistJumped, z) ) );
		}
	}

	IEnumerator Jump( Action<float> onComplete ) {
		startJumpPos = transform.position;

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		rigidbody.AddForce( Vector3.up, ForceMode.Impulse );

		while( rigidbody.velocity.y > 0f ) {
			yield return null;
		}

		float z = Vector3.Distance(transform.position, startJumpPos);

		onComplete(z);
	}
}