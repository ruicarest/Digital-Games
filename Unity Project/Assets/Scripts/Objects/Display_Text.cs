using UnityEngine;
using System.Collections;

public class Display_Text : MonoBehaviour {

	new public GUIText textObject;

	void OnMouseOver() {
		textObject.text = gameObject.name;
	}
	
	void OnMouseExit()
	{
		textObject.text = "";
	}


	void Update() {


	}
}





