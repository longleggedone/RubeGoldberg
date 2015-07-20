using UnityEngine;
using System.Collections;

public class triggerdemo : MonoBehaviour {

	//space to set desired particle effect
	public GameObject particleEffect;
	bool didITriggerYet = false;
	// Update is called once per frame
	void Update () {
		if (didITriggerYet == true){
			//turns on inactive particle effect, make sure it is deactive beforehand
			particleEffect.SetActive(true);
			//Debug.Log ("it worked");
		}
	}
	//whenever an object with a rigidbody and a collider enters the trigger the code will execute
	void OnTriggerEnter(){
		didITriggerYet = true;
	}
}
