using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Intermediate_12_1 : MonoBehaviour {

	public Intermediate_12_2 combatButton;

	void OnEnable() {
		combatButton.combatToggled += CombatToggled;
	}

	void OnDisable() {
		combatButton.combatToggled -= CombatToggled;
	}

	public void CombatToggled( bool toState ) {
		if( toState ) {} // put up yer dukes
		else {} // put up yer feet
	}
}