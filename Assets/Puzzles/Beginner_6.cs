using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_6 : MonoBehaviour {

	public bool IsIdle() {
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		return !( (rigidbody.IsSleeping() || rigidbody.velocity.magnitude < 1f) && (Input.GetKeyDown(KeyCode.None)) );
	}
}
