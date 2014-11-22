using UnityEngine;
using System.Collections;

public class Door_Listener : MonoBehaviour {

	public AnimationClip Closing; 
	public AnimationClip Openning; 

	private bool Isopen = false;

	// Use this for initialization
	void Start () {

	 
	}

	void Start_Action(float damage) {
		print (damage);

		if (!animation.isPlaying) {
			if(Isopen == false){
			animation.Play (Openning.name);
			Isopen = true;
			}
			else if (Isopen == true)
			{
			//animation.Play ("Door_Closing");
			animation.Play(Closing.name);
			Isopen = false;
			}
		
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
