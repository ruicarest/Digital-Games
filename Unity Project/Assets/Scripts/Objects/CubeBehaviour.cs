using UnityEngine;
using System.Collections;


public class CubeBehaviour : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}

	void Start_Action(float damage) {
			print (damage);

		if (!animation.isPlaying) {
			animation.Play ();		
		}
			/*Animator anim = GetComponent<Animator> ();
	anim.Play("move_up");
	*/
			animation.Play ("move_up");
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
