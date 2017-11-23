using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour {

	private static Vector3 defaultPosition = new Vector3(-0.3558303f, -2.265788f, -1.609823f);
	private static Vector3 incorrectPosition = new Vector3(-100f, -100f, -100f);

	public GameObject timeObject;
	private TimeInstance timeHolder;

	// Use this for initialization
	void Start () {
		timeHolder = timeObject.GetComponent("TimeInstance") as TimeInstance;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = timeHolder.isEgg () ? incorrectPosition : defaultPosition;
	}
}
