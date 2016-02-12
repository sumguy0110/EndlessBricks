using UnityEngine;
using System.Collections;

public class Intermediate_15_2 : MonoBehaviour {

	public static Intermediate_15_2 instance;

	protected delegate void DestroyedDelegate();
	protected event DestroyedDelegate DestroyedEvent;

	public Intermediate_15_2() {
		if( instance == null ) {
			instance = this;
		}
		else {
			DestroyedEvent();
			Destroy( this );
		}
	}
}
