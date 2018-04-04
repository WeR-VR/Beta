using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour {
	public string loadLevel;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			
				GoInside();
			}

	}
	private void GoInside()
	{
		SceneManager.LoadScene(loadLevel);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
