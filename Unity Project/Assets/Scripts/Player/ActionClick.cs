using UnityEngine;
using System.Collections;


public class ActionClick : MonoBehaviour {

	new private RaycastHit hit;
	new private Ray ray;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {

				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast (ray, out hit, 1F)) {
				print (hit.collider.gameObject.name);

				hit.collider.gameObject.SendMessage("Start_Action",1);

				}
				
		}


	}
}
