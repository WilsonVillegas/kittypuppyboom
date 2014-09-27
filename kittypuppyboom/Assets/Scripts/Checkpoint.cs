using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	private bool triggered = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(!triggered){
			if(this.name.Equals("Cat")){
				other.gameObject.GetComponent<CatController>().lastCheckpoint++;
			}else{
				other.gameObject.GetComponent<DogController>().lastCheckpoint++;
			}

			Debug.Log ("Checkpoint!");

			triggered = true;
		}
	}
}
