using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour {

	private bool buff;
	private bool currState;
	private GameObject controller;

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag.Equals("catPowerUp") && currState != controller
	}

	void OnTriggerEnter(Collider other)
	{

	}
}
