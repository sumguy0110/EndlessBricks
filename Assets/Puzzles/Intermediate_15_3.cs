using UnityEngine;
using System.Collections;

public class Intermediate_15_3 : Intermediate_15_2, Intermediate_15_1 {

	public Intermediate_15_3() {
		DestroyedEvent += Destroyed;
	}

	public void AddElement<T>( T elementToAdd, T[] collection ) {
		T[] oldElements = collection;

		T[] newElements = new T[oldElements.Length + 1];

		for( int index = 0; index < oldElements.Length; index++ ) {
			newElements[index + 1] = oldElements[index];
		}

		newElements[0] = elementToAdd;
	}

	public void Destroyed() {
		DestroyedEvent -= Destroyed;

		// clean up class variables, etc.
	}
}
