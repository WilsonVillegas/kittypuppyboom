using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public CatController cat;
	public DogController dog;
	public GameObject[] catPlatforms;
	public GameObject[] dogPlatforms;

	public float speedAmount;
	public float slowAmount;
	public float shrinkAmount;
	public float waitAmount;

	public bool catState;
	public bool dogState;

	// Use this for initialization
	void Start () {
		catPlatforms = GameObject.FindGameObjectsWithTag("CatPlatform");
		dogPlatforms = GameObject.FindGameObjectsWithTag("DogPlatform");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DogJump(){
		catState = !catState;
	}

	public void CatJump(){
		dogState = !dogState;
	}

	public void SpeedPowerUp(float player)
	{
		Debug.Log(player);
		StartCoroutine(SpeedPowerUpHelper(player));
	}

	private IEnumerator SpeedPowerUpHelper(float player)
	{
		Debug.Log("speed power up");
		if(player == 0)
		{
			Debug.Log("cat speed");
			cat.changeSpeed(speedAmount);
			yield return new WaitForSeconds(waitAmount);
			cat.changeSpeed(-speedAmount);
		}
		else
		{
			Debug.Log("dog speed");
			dog.changeSpeed(speedAmount);
			yield return new WaitForSeconds(waitAmount);
			dog.changeSpeed(-speedAmount);
		}
	}

	public void ShrinkPowerUp(bool player)
	{
		StartCoroutine(ShrinkPowerUpHelper(player));
	}

	private IEnumerator ShrinkPowerUpHelper(bool player)
	{
		ChangePlatformSize(player,shrinkAmount);
		yield return new WaitForSeconds(waitAmount);
		ChangePlatformSize(player,-shrinkAmount);
	}

	private void ChangePlatformSize(bool player, float size)
	{
		if(!player)
		{
			for(int i = 0; i < catPlatforms.Length; i++)
			{
				catPlatforms[i].transform.localScale += new Vector3(0,size,0);
			}
		}
		else
			for(int i = 0; i < dogPlatforms.Length; i++)
			{
				dogPlatforms[i].transform.localScale += new Vector3(0,size,0);
			}
	}
	public void SlowPowerUp(float player)
	{
		StartCoroutine(SlowPowerUpHelper(player));
	}

	public IEnumerator SlowPowerUpHelper(float player)
	{
		if(player == 0)
		{
			cat.changeSpeed(slowAmount);
			yield return new WaitForSeconds(waitAmount);
			cat.changeSpeed(-slowAmount);
		}
		else
		{
			dog.changeSpeed(slowAmount);
			yield return new WaitForSeconds(waitAmount);
			dog.changeSpeed(-slowAmount);
		}
	}

	public void DogWin(){
		Application.LoadLevel ("DogWin");
	}

	public void CatWin(){
		Application.LoadLevel ("CatWin");
	}


}
