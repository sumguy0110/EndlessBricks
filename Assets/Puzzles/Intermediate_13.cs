using UnityEngine;
using System.Collections;

// What will be the value of v after one second?

public class Intermediate_13 : MonoBehaviour {

	float v = 10f;

	void Start() {
		v = Mathf.Pow(v, 10f);
	}

	void Awake() {
		v = Mathf.Sqrt(v);
	}

	void OnLevelWasLoaded() {
		v = v * Mathf.PI;
	}

	void Update() {
		v += Time.deltaTime;
	}

	void LateUpdate() {
		v -= Time.deltaTime;
	}

	void FixedUpdate() {
		v /= 2f;
	}
}