using UnityEngine;
using System.Collections;

public class Beginner_5 : MonoBehaviour {

	public Transform npc;
	public float fov;

	public bool visible = false;

	void Update() {
		if( Vector3.Dot( transform.forward, npc.position - transform.position ) > 1f - fov ) {
			visible = true;
		}
		else visible = false;
	}
}
