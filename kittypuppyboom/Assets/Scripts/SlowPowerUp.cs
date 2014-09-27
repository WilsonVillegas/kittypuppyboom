using UnityEngine;
using System.Collections;

public class SlowPowerUp : MonoBehaviour {

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
		if(this.tag.Equals("catPowerUp") && buff){
			controller.SlowPowerUp(0);
		}else if (this.tag.Equals("catPowerUp")){
			controller.SlowPowerUp(1);
		}else if (buff){
			controller.SlowPowerUp(1);
		} else {
			controller.SlowPowerUp(0);
		}
		Destroy(gameObject);
	}
}
