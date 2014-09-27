using UnityEngine;
using System.Collections;

public class SlowPowerUp : MonoBehaviour {
	public bool buff;
	private GameController controller;
	
	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag.Equals("catPowerUp") && buff != controller.catState){
			buff = controller.catState;
		}else if(this.tag.Equals("dogPowerUp") && buff != controller.dogState){
			buff = controller.dogState;
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
