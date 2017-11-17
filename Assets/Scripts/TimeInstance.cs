using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInstance : MonoBehaviour {

	private float time;

	void Start() {
		time = 0;
	}

	void Update() {
		time += 0.04f;
		if (time >= 20f)
			time = 0;
	}

	public float getTime() {
		return time;
	}
}
