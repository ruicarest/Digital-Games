using UnityEngine;
using System.Collections;


public class ActionClick : MonoBehaviour {

	//public GUIText GuiText;
	new public float Click_Range = 1F;

	new private RaycastHit hit;
	new private Ray ray;
	new private Vector3 cam = new Vector3(0.5f,0.5f,0f);

	

	// Use this for initialization
	void Start () {
	
		Screen.showCursor = false;
	}

	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;
		if (Input.GetButtonDown ("Fire1")) {

			ray = Camera.main.ViewportPointToRay (cam);

			if (Physics.Raycast (ray, out hit, Click_Range)) {

					if (hit.collider.gameObject.tag == "Clickable") {

					print (hit.collider.gameObject.name);
					hit.collider.gameObject.SendMessage("Start_Action",1);
				
					//GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
					//GuiText.text = "hello";

				   }
			}
		}



	}
}
