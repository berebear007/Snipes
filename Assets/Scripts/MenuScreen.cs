using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Screen.orientation = ScreenOrientation.Landscape;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void LevelOneLoad()
	{

		SceneManager.LoadScene("Debug");

	}
}
