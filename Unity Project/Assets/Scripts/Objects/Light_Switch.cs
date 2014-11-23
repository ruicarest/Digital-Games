using UnityEngine;
using System.Collections;

public class Light_Switch : MonoBehaviour {


	public Light LinkedLight;

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
	
	}

	void Start_Action(float damage) {

		LinkedLight.enabled = !LinkedLight.enabled;

	}
}
