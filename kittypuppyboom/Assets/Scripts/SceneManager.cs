using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public string m_scene;
	public string m_startkeys;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("q") && Input.GetKey("p") && (m_startkeys == "qp" || m_startkeys == "pq"))
		{
			Application.LoadLevel (m_scene); 
		}
		if(Input.GetKey("space") && m_startkeys == "q")
		{
			Application.LoadLevel (m_scene); 
		}
		if(Input.GetKey("space") && m_startkeys == "p")
		{
			Application.LoadLevel (m_scene); 
		}
	}
}
