using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInstance : MonoBehaviour {

	private static float MAX_TIME = 18f;

	private float time;
	private bool playBack = false;
	private bool paused = false;

	void Start() {
		resetTime();
	}

	void Update() {
		if (paused) return;
		time = time + 0.04f * (playBack == false ? 1 : -1);
		if (time > MAX_TIME)
			time = 0;
		if (time < 0)
			time = MAX_TIME;
	}

	public float getTime() {
		return time;
	}

	public void setPaused(bool paused) {
		this.paused = paused;
	}

	public void setPlayBack(bool playBack) {
		this.playBack = playBack;
	}

	public void resetTime() {
		time = 0;
	}
}
