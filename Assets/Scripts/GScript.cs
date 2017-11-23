using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GScript : MonoBehaviour {

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
		MelodyProvider.Note[] notes = timeHolder.isEgg() ? MelodyProvider.notes1 : MelodyProvider.notes2;
		for (int i = 0; i < notes.Length; i++) {
			MelodyProvider.Note note = notes [i];
			if (note.key == 'g') {
				Vector3 position = Mover.getKeyPositionDelta (defaultPosition, note.time, timeHolder.getTime ());
				if (position != Vector3.zero)
					transform.position = position;
			}
		}
		if (transform.position.y <= 0.7f && !audio.isPlaying)
			audio.Play ();
	}
}
