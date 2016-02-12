using UnityEngine;
using System.Collections;

public class ConstrainDirection : MonoBehaviour {

	public Transform target;
	
	void FixedUpdate () {
		transform.LookAt( target );
	}
}
