﻿using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		collision.gameObject.transform.parent = gameObject.transform;
	}

	void OnCollisionExit(Collision collision)
	{
		collision.gameObject.transform.parent = null;
	}
}
