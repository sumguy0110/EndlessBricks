using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_7 : MonoBehaviour {

	void EnableRecursively( bool toggle, Renderer r ) {
		r.enabled = toggle;

		foreach( Transform t in transform ) {
			EnableRecursively( toggle, t.GetComponent<Renderer>() );
		}
	}
}
