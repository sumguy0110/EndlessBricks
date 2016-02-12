using System;
using UnityEngine;
using System.Collections;
using Extensions;

// What is being used in this script?  Why?

namespace Extensions {

public static class StringExt {

	public static bool FirstLetterIsCapitalized( this string inWord ) {
		return Char.ToUpper(inWord[0]) == inWord[0];
	}
}

}

public class Advanced_16 : MonoBehaviour {

	public string myName;

	void Start() {
		if( myName.FirstLetterIsCapitalized() ) {
			// party!
		}
	}
}
