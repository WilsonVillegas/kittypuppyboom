using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour {
	
	public float jumpHeight;
	public float acceleration;
	public float maxSpeed;
	public float airSpeed;
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
		float arspd;
		if(Physics.OverlapSphere(groundCheck.position,.1f,groundLayer).Length != 0)
		{
			grounded = true;
			arspd = 1;
		}
		else
		{
			grounded = false;
			arspd = airSpeed;
		}
	
		if(Input.GetButton("Left"))
		{
			rigidbody.velocity += new Vector3(Input.GetAxis("Left")*acceleration*arspd,0,0);
			if(Mathf.Abs(rigidbody.velocity.x)>Mathf.Abs(maxSpeed))
				rigidbody.velocity = new Vector3(maxSpeed,rigidbody.velocity.y,0);
		}

		if(grounded && Input.GetButtonDown("CatJump"))
		{
			controller.CatJump();
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
		maxSpeed += changeAmt;
	}

	public void dead(){
		transform.position = new Vector3(checkPoints[lastCheckpoint].position.x, checkPoints[lastCheckpoint].position.y + 0.5f, transform.position.z);
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
