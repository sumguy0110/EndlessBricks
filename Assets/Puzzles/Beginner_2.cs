using UnityEngine;
using System.Collections;

// What does this script do?  Why?

public class Beginner_2 : MonoBehaviour {

	public string date {
		get {
			if( _date >= 0 ) return _date + " AD";
			else return "BCE " + date;
		}
		set {
			string trimmedDate = value.Replace("AD", "").Replace("BCE", "").Trim();

			if( int.TryParse( trimmedDate, out _date ) ) {}
			else _date = 0;
		}
	}

	int _date;
}
