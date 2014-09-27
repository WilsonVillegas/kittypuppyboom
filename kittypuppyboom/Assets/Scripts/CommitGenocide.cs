using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private GameController controller;

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(this.tag.Equals("catWin")){
			controller.CatWin();
		}else{
			controller.DogWin()
		}
	}
}
