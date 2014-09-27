using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour {
	Animator animator;
	public float delay;
	public float resetTime;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag.Equals("Dog") || other.tag.Equals("Cat"))
		{
			StartCoroutine(playerHit());
		}
	}

	/*void OnTriggerExit(Collider other)
	{
		if(other.tag.Equals("Dog") || other.tag.Equals("Cat"))
		{
			animator.SetBool("PlayerHit",false);
		}
	}*/

	IEnumerator playerHit()
	{
		yield return new WaitForSeconds(delay);
		animator.SetBool("PlayerHit",true);
		yield return new WaitForSeconds(resetTime);
		animator.SetBool("PlayerHit",false);
	}

}
