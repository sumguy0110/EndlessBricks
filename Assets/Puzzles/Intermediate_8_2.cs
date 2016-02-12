using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Intermediate_8_2 : Intermediate_8_1 {

	public Color multColor;

	void Start() {
		Method();
	}

	sealed protected override void Method() {
		c *= multColor;

		base.Method();
	}
}
