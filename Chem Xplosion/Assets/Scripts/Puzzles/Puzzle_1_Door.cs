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


    // Update is called once per frame
    void Update()
    {
        puzzleOneComplete = PuzzleOneTable.isComplete_Puzzle_1;

        if (puzzleOneComplete == true)
        {
            Invoke("openDoor", 1);
        }
    }
    void openDoor()
    {
        dAnimate.SetBool("open", true);
    }
}
