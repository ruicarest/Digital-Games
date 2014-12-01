using UnityEngine;
using System.Collections;

public class Player_dying : MonoBehaviour {
	
	public AnimationClip Dying;  
	
	private bool Isopen = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Die(float damage) {
		
		if (!animation.isPlaying) {


				animation.Play(Dying.name);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}