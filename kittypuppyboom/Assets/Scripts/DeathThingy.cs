using UnityEngine;
using System.Collections;

public class DeathThingy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name.Equals("Cat")){
			other.gameObject.GetComponent<CatController>().dead();
		}else{
			other.gameObject.GetComponent<DogController>().dead();
		}
	}
}
