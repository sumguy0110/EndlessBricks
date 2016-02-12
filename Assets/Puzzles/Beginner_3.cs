using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_3 : MonoBehaviour {

	public Rigidbody grenade;

	public Transform launcher;

	float timeHeld = 0f;

	void Update() {
		if( Input.GetMouseButton(1) ) timeHeld += Time.deltaTime;
		if( Input.GetMouseButtonUp(1) ) {
			Click( (int)timeHeld );
			timeHeld = 0f;
		}
	}

	void Click( float timeHeld ) {
		Rigidbody grenade = Instantiate( this.grenade, launcher.position, launcher.rotation ) as Rigidbody;
		grenade.AddForce( launcher.forward );
	}
}
