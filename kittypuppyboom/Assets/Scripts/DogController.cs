﻿using UnityEngine;
using System.Collections;

public class DogController : MonoBehaviour {

	public float jumpHeight;
	public float moveSpeed;
	public Transform groundCheck;
	public LayerMask groundLayer;
	public Transform[] checkPoints;
	public int lastCheckpoint;
	public float spawnOffset;

	private Vector3 moveVector;
	private bool grounded;
	private GameController controller;

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
		lastCheckpoint = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.OverlapSphere(groundCheck.position,.1f,groundLayer).Length != 0)
		{
			grounded = true;
		}
		else
			grounded = false;
		
		if(Input.GetButton("Right"))
		{
			rigidbody.velocity = new Vector3(moveSpeed,rigidbody.velocity.y,0);
		}
		
		if(grounded && Input.GetButtonDown("DogJump"))
		{
			controller.DogJump();
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,jumpHeight,0);
			grounded = false;
		}
	}

	public void changeJump(float changeAmt)
	{
		jumpHeight += changeAmt;
	}
	
	public void changeSpeed(float changeAmt)
	{
		moveSpeed += changeAmt;
	}

	public void dead(){
		transform.position = checkPoints[lastCheckpoint].position + new Vector3(0,0,spawnOffset);
		/*switch(lastCheckpoint){
		case 0:
			// move char to lastCheckpoint location
			break;
			
		case 1:
			// move char to lastCheckpoint location
			break;
			
		case 2:
			// move char to lastCheckpoint location
			break;
			
		case 3:
			// move char to lastCheckpoint location
			break;
			
		case 4:
			// move char to lastCheckpoint location
			break;
		}*/
	}
		

}
