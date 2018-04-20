using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpScript : MonoBehaviour {
	public bool checkInput;
	// Use this for initialization
	void Start () {
		checkInput = true;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerScript.score);
		if (PlayerScript.score >= 150) {

			OnClick ();
		} 

	}

	void OnClick()
	{
		if (Input.GetKeyDown (KeyCode.X) && checkInput == true) {
			
			PlayerScript.health = PlayerScript.health + 150;
			checkInput = false;
		}
	}
}
