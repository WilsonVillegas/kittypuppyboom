using UnityEngine;
using System.Collections;

public class ShrinkPowerUp : MonoBehaviour {

	private GameController controller;
	public bool state; //0 = cat, 1 = dog

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
	 if(tag.Equals("CatPowerUp"))
		{
			state = !controller.catState; //True catstate = 1, so we need to change it to 0 so it applies to cats
		}
		else
		{
			state = controller.dogState; //True dog state = 1, which is correct.
		}
	}

	void OnTriggerEnter(Collider other)
	{
		controller.ShrinkPowerUp(state);
		Destroy(gameObject);
	}
}
