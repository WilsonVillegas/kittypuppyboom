using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour {

	public bool buff;
	private GameController controller;
	Animator animator;

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag.Equals("catPowerUp") && buff != controller.catState){
			{
				buff = controller.catState;
				animator.SetBool("State",buff);
			}
		}else if(this.tag.Equals("dogPowerUp") && buff != controller.dogState){
			{
				buff = controller.dogState;
				animator.SetBool("State",buff);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("should be triggering things");
		if(this.tag.Equals("catPowerUp") && buff){
			controller.SpeedPowerUp(0);
		}else if (this.tag.Equals("catPowerUp")){
			controller.SpeedPowerUp(1);
		}else if (buff){
			controller.SpeedPowerUp(1);
		} else {
			controller.SpeedPowerUp(0);
		}
		Destroy(gameObject);
	}
}
