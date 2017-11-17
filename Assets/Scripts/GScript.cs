using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GScript : MonoBehaviour {

	public GameObject timeObject;
	private TimeInstance timeHolder;

	public AudioSource audio;

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
		transform.position += KeyMover.getPositionDelta(defaultPosition, 8f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 11f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 16f, timeHolder.getTime());
		if (transform.position.y <= -0.3f && !audio.isPlaying)
			audio.Play ();
	}
}
