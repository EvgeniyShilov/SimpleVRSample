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
	private Vector3 dPos;
	private Vector3 aPos;
	private Vector3 bPos;
	private Vector3 gPos;

	// Use this for initialization
	void Start () {
		timeHolder = timeObject.GetComponent("TimeInstance") as TimeInstance;
		dPos = dButton.transform.position + Vector3.up * 0.75f;
		aPos = aButton.transform.position + Vector3.up * 0.75f;
		bPos = bButton.transform.position + Vector3.up * 1.25f + Vector3.forward;
		gPos = gButton.transform.position + Vector3.up * 0.75f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 da1 = Mover.getBallPosition (dPos, aPos, 0, 2, timeHolder.getTime ());
		Vector3 ad1 = Mover.getBallPosition (aPos, dPos, 2, 3, timeHolder.getTime ());
		Vector3 db1 = Mover.getBallPosition (dPos, bPos, 3, 4, timeHolder.getTime ());
		Vector3 ba1 = Mover.getBallPosition (bPos, aPos, 4, 6, timeHolder.getTime ());
		Vector3 ag1 = Mover.getBallPosition (aPos, gPos, 6, 7, timeHolder.getTime ());
		Vector3 ga1 = Mover.getBallPosition (gPos, aPos, 7, 8, timeHolder.getTime ());
		Vector3 ag2 = Mover.getBallPosition (aPos, gPos, 8, 10, timeHolder.getTime ());
		Vector3 ga2 = Mover.getBallPosition (gPos, aPos, 10, 11, timeHolder.getTime ());
		Vector3 ab1 = Mover.getBallPosition (aPos, bPos, 11, 12, timeHolder.getTime ());
		Vector3 ba2 = Mover.getBallPosition (bPos, aPos, 12, 14, timeHolder.getTime ());
		Vector3 ag3 = Mover.getBallPosition (aPos, gPos, 14, 15, timeHolder.getTime ());
		Vector3 gd1 = Mover.getBallPosition (gPos, dPos, 15, 16, timeHolder.getTime ());
		Vector3 dd1 = Mover.getBallPosition (dPos, dPos, 16, 18, timeHolder.getTime ());
		if (da1 != Vector3.zero) transform.position = da1 + dPos;
		if (ad1 != Vector3.zero) transform.position = ad1 + aPos;
		if (db1 != Vector3.zero) transform.position = db1 + dPos;
		if (ba1 != Vector3.zero) transform.position = ba1 + bPos;
		if (ag1 != Vector3.zero) transform.position = ag1 + aPos;
		if (ga1 != Vector3.zero) transform.position = ga1 + gPos;
		if (ag2 != Vector3.zero) transform.position = ag2 + aPos;
		if (ga2 != Vector3.zero) transform.position = ga2 + gPos;
		if (ab1 != Vector3.zero) transform.position = ab1 + aPos;
		if (ba2 != Vector3.zero) transform.position = ba2 + bPos;
		if (ag3 != Vector3.zero) transform.position = ag3 + aPos;
		if (gd1 != Vector3.zero) transform.position = gd1 + gPos;
		if (dd1 != Vector3.zero) transform.position = dd1 + dPos;
	}
}
