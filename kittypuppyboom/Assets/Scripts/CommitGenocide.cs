using UnityEngine;
using System.Collections;

public class CommitGenocide : MonoBehaviour {

	private GameController controller;

	// Use this for initialization
	void Start () {
		controller = GameObject.Find("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(this.name.Equals("Dog Planet")){
			controller.CatWin();
		}else{
			controller.DogWin();
		}

		Debug.Log("Boom");
	}
}
