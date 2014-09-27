using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	private float diff;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		//diff = collision.gameObject.transform.position.x - this.transform.position.x;
		collision.gameObject.transform.parent = gameObject.transform;
		//collision.gameObject.rigidbody.detectCollisions = false;
		//collision.gameObject.rigidbody.isKinematic = true;
		Debug.Log("boink");
	}
	/*
	void OnCollisionStay(Collision collision){
		Transform temp = collision.gameObject.transform;
		Vector3 vec;

		if(temp.position.x - this.transform.position.x > diff)
			vec = new Vector3(temp.position.x + diff, temp.position.y, temp.position.z);
		else
			vec = new Vector3(temp.position.x - diff, temp.position.y, temp.position.z);

		temp.position = vec;
	}
	*/

	void OnCollisionExit(Collision collision)
	{

		collision.gameObject.transform.parent = null;
		//collision.gameObject.rigidbody.detectCollisions = true;
		//collision.gameObject.rigidbody.isKinematic = false;
		Debug.Log("oink");
	}
}
