using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInstance : MonoBehaviour {

	public static float MAX_TIME = 18f;

	private float time;
	private bool playBack = false;
	private bool paused = true;
	private bool egg = true;

	void Start() {
		resetTime();
	}

	void Update() {
		if (paused) return;
		time = time + 0.03f * (playBack == false ? 1 : -1);
		if (time > MAX_TIME)
			time = 0;
		if (time < 0)
			time = MAX_TIME;
	}

	public float getTime() {
		return time;
	}

	public void setPaused(bool paused) {
		Debug.Log ("setPaused()");
		Invoke (paused ? "setPausedTrue" : "setPausedFalse", 1);
	}

	public void setPausedTrue() {
		Debug.Log ("setPausedTrue()");
		this.paused = true;
	}

	public void setPausedFalse() {
		Debug.Log ("setPausedFalse()");
		this.paused = false;
	}

	public void setPlayBack(bool playBack) {
		Debug.Log ("setPlayBack()");
		Invoke (playBack ? "setPlayBackTrue" : "setPlayBackFalse", 1);
	}

	public void setPlayBackTrue() {
		Debug.Log ("setPlayBackTrue()");
		this.playBack = true;
	}

	public void setPlayBackFalse() {
		Debug.Log ("setPlayBackFalse()");
		this.playBack = false;
	}

	public void resetTime() {
		Debug.Log ("resetTime()");
		Invoke ("resetTimeInstantly", 1);
	}

	public void resetTimeInstantly() {
		Debug.Log ("resetTimeInstantly()");
		time = 0;
	}

	public void cancelInvoke() {
		Debug.Log ("CancelInvoke()");
		CancelInvoke ();
	}

	public void changeMelody() {
		Debug.Log ("changeMelody()");
		Invoke ("changeMelodyInstantly", 1);
	}

	public void changeMelodyInstantly() {
		egg = !egg;
	}

	public bool isEgg() {
		return egg;
	}
}
