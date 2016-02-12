using UnityEngine;
using System.Collections;

public class ConstrainPosition : MonoBehaviour {

	public Transform target;
	
	void FixedUpdate () {
		transform.position = target.position;
	}
}
