using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_4 : MonoBehaviour {

	public void PreventGimbalLock( Vector3 v ) {
		Vector3 a = transform.eulerAngles;

		transform.eulerAngles = new Vector3( (a.x + v.x) % 360f, (a.y + v.y) % 360f, (a.z + v.z) % 360f );
	}
}
