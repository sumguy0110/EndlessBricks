using UnityEngine;
using System.Collections;

public class Basic_2 : MonoBehaviour {

	public bool Method1( Transform obj1, Transform obj2, float dist = 1f ) {
		return Method1( obj1.position, obj2.position, dist );
	}

	public bool Method1( Transform obj1, Vector3 pos2, float dist = 1f ) {
		return Method1( obj1.position, pos2, dist );
	}

	public bool Method1( Vector3 pos1, Transform obj2, float dist = 1f ) {
		return Method1( pos1, obj2.position, dist );
	}

	public bool Method1( Vector3 pos1, Vector3 pos2, float dist ) {
		if( Vector3.Distance( pos1, pos2 ) < dist ) return true;

		return false;
	}
}
