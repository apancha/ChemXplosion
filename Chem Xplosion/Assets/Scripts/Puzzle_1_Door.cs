using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1_Door : MonoBehaviour {

	private Animator dAnimate;
	public static bool puzzleOneComplete;
	// Use this for initialization
	void Start () {
		dAnimate = GetComponent<Animator> ();
	}

//	void OnTriggerEnter(Collider col){
//		if (col.tag == "Player") {
			
//		}
//	}

	// Update is called once per frame
	void Update () {
		puzzleOneComplete = Onhit.isComplete_Puzzle_1;

		if (puzzleOneComplete == true){
		dAnimate.SetBool ("open", true);
	}
}
}
