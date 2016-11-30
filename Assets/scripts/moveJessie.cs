using UnityEngine;
using System.Collections;

public class moveJessie : MonoBehaviour {

	Animator myAnim;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent <Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey("q")){
			myAnim.SetTrigger ("SleepTrigger");
		}
		if(Input.GetKey("e")){
			myAnim.SetTrigger ("WakeUpTrigger");
		}
	}
}
