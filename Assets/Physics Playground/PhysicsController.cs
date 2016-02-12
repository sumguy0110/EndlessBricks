using UnityEngine;
using System.Collections;

public class PhysicsController : MonoBehaviour {

	public float rollSpeed = 10f;
	public float maxRollSpeed = 10f;
	public float jumpPower = 10f;

	Rigidbody roll;
	Camera cam;

	public float rotSpeed = 10f;

	float distFromTarget;

	void Start () {
		roll = GetComponent<Rigidbody>();
		cam = Camera.main;
	}
	
	void Update () {
		float vert = Input.GetAxis("Vertical");
		if( Mathf.Abs(vert) > 0f ) {
			Vector3 dirToMarble = (transform.position - new Vector3( cam.transform.position.x, transform.position.y, cam.transform.position.z ) ).normalized;

			roll.AddForce( dirToMarble * rollSpeed * vert, ForceMode.Acceleration );

			float mag = roll.velocity.magnitude;
			if( mag > maxRollSpeed ) {
				roll.velocity /= mag / maxRollSpeed;
			}
		}

		float horiz = Input.GetAxis("Horizontal");
		if( Mathf.Abs(horiz) > 0f ) {
			cam.transform.RotateAround( transform.position, Vector3.up, rotSpeed * Time.deltaTime * horiz );
		}

		if( Input.GetKeyDown( KeyCode.Space ) ) {
			roll.AddForce( Vector3.up * jumpPower, ForceMode.Impulse );
		}
	}
}
