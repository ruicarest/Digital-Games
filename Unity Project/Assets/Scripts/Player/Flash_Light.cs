using UnityEngine;
using System.Collections;

public class Flash_Light : MonoBehaviour {
	
	public Light LinkedLight_in;
	public Light LinkedLight_out;
	public int Flash = 1;
	private int Flash_rand;
	private bool lightOn = true; 
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		/*Flash_rand = Random.Range (0,100);

		if(LinkedLight_in.enabled == true && Flash_rand <= Flash && lightOn){

			LinkedLight_in.enabled = !LinkedLight_in.enabled;	

		}
*/
		if (Input.GetKeyDown(KeyCode.Q)) {

			lightOn = !lightOn;
			LinkedLight_out.enabled = !LinkedLight_out.enabled;
			LinkedLight_in.enabled = !LinkedLight_in.enabled;
		
			}		
	}
}
