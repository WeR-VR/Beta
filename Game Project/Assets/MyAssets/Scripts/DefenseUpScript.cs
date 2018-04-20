using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseUpScript : MonoBehaviour {
	public GameObject defenseUp;
	public GameObject Barriers;
	GameObject barriersSpawn;
	// Use this for initialization
	void Start () {
		defenseUp.SetActive (true);
		transform.Translate (0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerScript.score);
		if (PlayerScript.score >= 50) {
			OnClick ();
		} 

	}

	 void OnClick()
	{
		if (Input.GetKeyDown (KeyCode.Z)) {
			PlayerScript.score = PlayerScript.score - 30;
			barriersSpawn = Instantiate(Barriers,transform.position, Quaternion.identity) as GameObject;
			defenseUp.SetActive (false);

		}
	}
}