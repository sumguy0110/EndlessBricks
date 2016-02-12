using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Intermediate_12_2 : MonoBehaviour {

	public delegate void CombatEvent( bool state );
	public event CombatEvent combatToggled;

	bool inCombat;

	void OnMouseDown() {
		inCombat = !inCombat;
		combatToggled( inCombat );
	}

	void OnDestroy() {
		combatToggled = null;
	}
}