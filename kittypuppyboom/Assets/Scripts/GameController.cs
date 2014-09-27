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

	public bool catPlat;
	public bool dogPlat;

	// Use this for initialization
	void Start () {
		catPlatforms = GameObject.FindGameObjectsWithTag("catPlatform");
		dogPlatforms = GameObject.FindGameObjectsWithTag("dogPlatform");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DogJump(){
		catPlat = !catPlat;
	}

	public void CatJump(){
		dogPlat = !dogPlat;
	}

	public IEnumerator SpeedPowerUp(float player)
	{
		if(player == 0)
		{
			cat.changeSpeed(speedAmount);
			yield return new WaitForSeconds(waitAmount);
			cat.changeSpeed(-speedAmount);
		}
		else
		{
			dog.changeSpeed(speedAmount);
			yield return new WaitForSeconds(waitAmount);
			dog.changeSpeed(-speedAmount);
		}
	}

	/*public IEnumerator ShrinkPowerUp(float player)
	{
		if(player == 0)
		{

		}
		else
		{
			
		}
	}*/

	public IEnumerator SlowPowerUp(float player)
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


}
