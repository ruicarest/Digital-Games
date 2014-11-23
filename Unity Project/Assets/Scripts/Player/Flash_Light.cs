using UnityEngine;
using System.Collections;

public class Flash_Light : MonoBehaviour {
	
	public Light LinkedLight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.Q)) {
			
			LinkedLight.enabled = !LinkedLight.enabled;
		
			}		
	}
}
