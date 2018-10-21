using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ShowMainMenu();
	}

	// Update is called once per frame
	void Update () {

	}

	void ShowMainMenu () {
		Terminal.ClearScreen();
		Terminal.WriteLine ("What would you like to hack into?");
		Terminal.WriteLine ("Press 1 for the local library");
		Terminal.WriteLine ("Press 2 for the local police station");
		Terminal.WriteLine ("Press 3 for NASA");

		Terminal.WriteLine ("Enter your selection: ");
	}
}