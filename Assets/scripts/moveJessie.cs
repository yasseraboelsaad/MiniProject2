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
		AudioSource audio = GameObject.Find ("Audio Source").GetComponent<AudioSource>();
		if(Input.GetKey("q")){
			myAnim.SetTrigger ("SleepTrigger");
			audio.Pause ();
		}
		if(Input.GetKey("e")){
			myAnim.SetTrigger ("WakeUpTrigger");
			audio.Play ();
		}
	}
}
