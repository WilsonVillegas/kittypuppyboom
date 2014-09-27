using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("q") && Input.GetButton("p"))
		{
			Application.LoadLevel ("Main"); 
		}
	}
}
