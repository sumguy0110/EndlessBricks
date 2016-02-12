using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Intermediate_9 : MonoBehaviour {

	public float t;
	public Collider[] enemies;

	public float r;

	public Collider enemyToChase = null;

	void Start() {
		StartCoroutine( Method1() );
	}

	IEnumerator Method1() {
		yield return StartCoroutine( Method2() );

		yield return StartCoroutine( Method3() );

		StartCoroutine( Method1() );
	}

	IEnumerator Method2() {
		while( enemyToChase == null ) {

			for( int i = 0; i < enemies.Length; i++ ) {

				if( Vector3.Distance( transform.position, enemies[i].bounds.center ) < r ) {
					RaycastHit vis;

					if( enemies[i].Raycast( new Ray(transform.position, enemies[i].transform.position - transform.position), out vis, r ) ) {
						enemyToChase = enemies[i];
						break;
					}
				}
			}

			yield return new WaitForSeconds( t );
		}
	}

	IEnumerator Method3() {
		while( enemyToChase ) {
			
			RaycastHit vis;

			if( enemyToChase.Raycast( new Ray(transform.position, enemyToChase.transform.position - transform.position), out vis, r ) ) {}
			else {
				enemyToChase = null;
			}

			yield return new WaitForSeconds( t );
		}
	}
}
