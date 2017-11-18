using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BScript : MonoBehaviour {

	public GameObject timeObject;
	private TimeInstance timeHolder;

	private AudioSource audio;

	private Vector3 defaultPosition;

	// Use this for initialization
	void Start () {
		timeHolder = timeObject.GetComponent("TimeInstance") as TimeInstance;
		audio = this.GetComponent("AudioSource") as AudioSource;
		defaultPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = defaultPosition;
		transform.position += Mover.getKeyPositionDelta(4f, timeHolder.getTime());
		transform.position += Mover.getKeyPositionDelta(12f, timeHolder.getTime());
		if (transform.position.y <= -0.3f && !audio.isPlaying)
			audio.Play ();
	}
}
