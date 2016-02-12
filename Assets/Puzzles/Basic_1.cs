using UnityEngine;
using System.Collections;

public class Basic_1 : MonoBehaviour {

	public Transform[] items;

	void Method1() {
		for( int index = 0; index < items.Length; index++ ) {
	        Transform temp = items[index];
	        int randomIndex = Random.Range(0, items.Length - 1);
	        items[index] = items[randomIndex];
	        items[randomIndex] = temp;
		}
	}
}
