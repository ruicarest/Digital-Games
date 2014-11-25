using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	private GameObject target ;

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

		target = GameObject.FindWithTag("Player");


		transform.LookAt(target.transform);

	}
}
