using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour {
	private int health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
			health = health - 15;
			if (health <= 0) {
				//dead.Play ();
				//PlayerScript.score += scoreValue;
				Destroy (transform.parent.gameObject);
			}
		}
	}
}
