using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController: MonoBehaviour {

	//Var decls
	public Transform tile;
	public Vector3 SpawnOrigin;
	public Button PauseButton;

	private GameObject groundSelector;

	// Use this for initialization
	void Start () {
		MapInit ();
	}
	
	// Update is called once per frame
	void Update () {
		UIUpdater ();
	}

	//UI Controls
	void UIUpdater()
	{

	}

	//Initialize map based on map file
	void MapInit ()
	{
		groundSelector = GameObject.Find("/Room/Ground/Selector");
		
		if (groundSelector == null)
		{
			Debug.Log("Did not find groundSelector");
		}

//		Debug.Log (groundSelector.tag);
		
		//Currently hardcoded map
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				Vector3 actualPosition = new Vector3((float)(SpawnOrigin.x+0.1*i), 
				                                     (float)(SpawnOrigin.y), 
				                                     (float)(SpawnOrigin.z+0.1*j));
				Transform newTile = (Transform)Instantiate(tile);
//				newTile = GameObject.FindWithTag("Tile");
//				GameObject newTile = GameObject.Find("GridItem(Clone)");
				newTile.transform.parent = groundSelector.transform;
				newTile.transform.localPosition = actualPosition;
				newTile.transform.localScale = new Vector3(0.01f, 1f, 0.01f);
			}
		}
	}
}
