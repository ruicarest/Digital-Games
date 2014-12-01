using UnityEngine;
using System.Collections;




public class walking_on_water : MonoBehaviour{

	public AudioClip backmusic;
	private bool hasPlayed = false;


	void OnTriggerEnter(Collider coll)
	{
		
		if(coll.gameObject.tag == "Player"){
			if(!hasPlayed){
			audio.PlayOneShot(backmusic, 1.0f);
			hasPlayed = true;
			}
		}
	}

	void OnTriggerExit(Collider coll) {
		audio.Stop ();
	}

}