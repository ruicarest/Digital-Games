using UnityEngine;
using System.Collections;

public class Pause_Game : MonoBehaviour {

	public static bool paused = false;
	
	void Start()
	{ 
		Time.timeScale = 1;
	}
	void Update () 
	{

		if(paused ==false)
			Screen.lockCursor = false;
		
		if(Input.GetKeyDown(KeyCode.Escape) && paused == false)
		{
			paused = true;
			Time.timeScale = 0;
		}
		else if(Input.GetKeyDown(KeyCode.Escape) && paused == true) 
		{ 
			paused = false;
			Time.timeScale = 1;
		}
	}
}