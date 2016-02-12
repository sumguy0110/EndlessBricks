using UnityEngine;
using System.Collections;

// What is being used in this script?  Why?

public class Intermediate_14 : MonoBehaviour {

	public Vector3 p;

	void Update() {
		#if UNITY_EDITOR 
			p = default(Vector3);
		#endif

		#if UNITY_STANDALONE
			p = Input.mousePosition;

		#elif UNITY_IPHONE
			if( Input.touches.Length > 0 ) {
				p = Input.touches[0];
			}
		#endif

		#if UNITY_4_5
			p = Event.current.mousePosition;

		#endif
	}


}