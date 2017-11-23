using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject timeObject;
	private TimeInstance timeHolder;

	public GameObject dButton;
	public GameObject aButton;
	public GameObject bButton;
	public GameObject gButton;
	public GameObject cButton;
	public GameObject eButton;
	public GameObject fButton;
	private Vector3 dPos;
	private Vector3 aPos;
	private Vector3 bPos;
	private Vector3 gPos;
	private Vector3 cPos;
	private Vector3 ePos;
	private Vector3 fPos;

	// Use this for initialization
	void Start () {
		timeHolder = timeObject.GetComponent("TimeInstance") as TimeInstance;
		dPos = dButton.transform.position + Vector3.up * 0.75f;
		aPos = aButton.transform.position + Vector3.up * 0.75f;
		bPos = bButton.transform.position + Vector3.up * 1.25f + Vector3.forward;
		gPos = gButton.transform.position + Vector3.up * 0.75f;
		cPos = cButton.transform.position + Vector3.up * 0.75f;
		ePos = eButton.transform.position + Vector3.up * 0.75f;
		fPos = fButton.transform.position + Vector3.up * 0.75f;
	}
	
	// Update is called once per frame
	void Update () {
		MelodyProvider.Note[] notes = timeHolder.isEgg() ? MelodyProvider.notes1 : MelodyProvider.notes2;
		for (int i = 0; i < notes.Length; i++) {
			MelodyProvider.Note current = notes [i];
			MelodyProvider.Note next = i + 1 == notes.Length ? notes[0] : notes [i + 1];
			float endTime = i + 1 == notes.Length ? TimeInstance.MAX_TIME : next.time;
			Vector3 currentPos = aPos;
			Vector3 nextPos = aPos;
			switch (current.key) {
				case 'a':
					currentPos = aPos;
					break;
				case 'b':
					currentPos = bPos;
					break;
				case 'g':
					currentPos = gPos;
					break;
				case 'd':
					currentPos = dPos;
					break;
				case 'c':
					currentPos = cPos;
					break;
				case 'e':
					currentPos = ePos;
					break;
				case 'f':
					currentPos = fPos;
					break;
			}
			switch (next.key) {
				case 'a':
					nextPos = aPos;
					break;
				case 'b':
					nextPos = bPos;
					break;
				case 'g':
					nextPos = gPos;
					break;
				case 'd':
					nextPos = dPos;
					break;
				case 'c':
					nextPos = cPos;
					break;
				case 'e':
					nextPos = ePos;
					break;
				case 'f':
					nextPos = fPos;
					break;
			}
			Vector3 position = Mover.getBallPosition (currentPos, nextPos, current.time, endTime, timeHolder.getTime ());
			if (position != Vector3.zero)
				transform.position = position;
		}
	}
}
