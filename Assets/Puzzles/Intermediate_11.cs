using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// What does this script do?  Why?

public class Intermediate_11 : MonoBehaviour {

	float rad = 10f;

	Collider nearestFood = null;

	void Start() {
		Collider[] nearestFoods = Physics.OverlapSphere( transform.position, rad );

		for( int i = 0; i < nearestFoods.Length; i++ ) {
			nearestFood = nearestFoods[i] ?? nearestFood.tag == "Consumed" && nearestFoods[i].tag == "Edible" ? nearestFoods[i] : nearestFood;
		}
	}
}
