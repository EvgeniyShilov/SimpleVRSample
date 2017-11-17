using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AScript : MonoBehaviour {

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
		transform.position += KeyMover.getPositionDelta(defaultPosition, 3f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 7f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 9f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 12f, timeHolder.getTime());
		transform.position += KeyMover.getPositionDelta(defaultPosition, 15f, timeHolder.getTime());
		if (transform.position.y <= -0.3f && !audio.isPlaying)
			audio.Play ();
	}
}
