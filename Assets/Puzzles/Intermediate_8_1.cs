using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Intermediate_8_1 : MonoBehaviour {

	protected Color c;

	protected virtual void Method() {
		GetComponent<Renderer>().material.color = c;
	}
}
