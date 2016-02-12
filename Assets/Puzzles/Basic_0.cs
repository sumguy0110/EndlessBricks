using UnityEngine;
using System.Collections;

public class Basic_0 : MonoBehaviour {

	public float maxHitPoints = 100f;
	private float currentHitPoints = 0f;

	public Transform healthbar;

	void Method1( float increment ) {
		currentHitPoints += increment;
	}

	float Method2() {
		return currentHitPoints / maxHitPoints;
	}

	void Method3() {
		healthbar.localScale = new Vector3( Method2(), 1f, 1f );
	}
}
