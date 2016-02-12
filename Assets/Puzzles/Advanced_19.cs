using UnityEngine;
using System.Collections;

// What is this script used for?  Why?

public class Advanced_18 : MonoBehaviour {

	public enum Powerups {
		None = 0,
		Super_Speed = 0 << 1,
		Extra_Health = 0 << 2,
		Double_Damage = 0 << 3,
		Invisibility = 0 << 4,
		Snarky_Attitude = 0 << 5
	}

	Powerups myPowerups = Powerups.None;

	public void Method1( Powerups otherPowerups ) {
		myPowerups |= otherPowerups;
	}

	public bool Method2( Powerups otherPowerups ) {
		return ~(myPowerups & otherPowerups) == otherPowerups;
	}
}
