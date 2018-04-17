using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRIP : MonoBehaviour {
	private int health = 100;
	public GameObject bossDead;
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
				Instantiate(bossDead,transform.position,transform.rotation);
				Destroy (transform.parent.gameObject);
			}
		}
	}
}
