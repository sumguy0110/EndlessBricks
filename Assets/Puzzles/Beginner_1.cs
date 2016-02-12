using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_1 : MonoBehaviour {

	public float tInterval = 0f;
	float t = 0f;

	int count = 0;

	void Update() {
		if( Input.GetMouseButtonDown(1) ) {
			if( Time.time - t < tInterval ) { count++; }
			else { count = 1; }

			t = Time.time;

			switch( count ) {
				case 1:
					/* do one thing */
				break;

				case 2:
					/* do another thing */
				break;

				case 3:
					/* do a third thing */
				break;
			}
		}
	}
}
