using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// What does this script do?  Why?

public class Intermediate_10 : MonoBehaviour {

	public List<GameObject> enemies;

	public int currentEnemy = 0;

	public void Method() {
		if( enemies.Count == 0 ) return;

		currentEnemy = (currentEnemy + 1) % enemies.Count;

		try {
			enemies[currentEnemy].SetActive( true );
		}
		catch( Exception e ) {
			if( e is NullReferenceException ) {
				enemies.RemoveAt(currentEnemy);
				currentEnemy++;
				Method();
			}
		}
	}
}
