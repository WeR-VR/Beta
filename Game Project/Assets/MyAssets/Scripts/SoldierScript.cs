using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierScript : MonoBehaviour {
	private float health = 100;
	public float moveSpeed;
	private Rigidbody playerBody;
	public int scoreValue = 10;
	public PlayerScript thePlayer;
	//public AudioSource dead;
	// Use this for initialization
	void Start () {

		playerBody = GetComponent<Rigidbody> ();
		thePlayer = FindObjectOfType<PlayerScript> ();
		//AudioSource dead = GetComponent<AudioSource> ();


	}

	// Update is called once per frame
	void fixedUpdate ()
	{

	}

	void Update () {
		transform.LookAt (thePlayer.transform.position);
		playerBody.velocity = (transform.forward * moveSpeed);
	}




	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
			health = health - 25;
			if (health <= 0) {
			//	dead.Play ();
				Destroy(this.gameObject);
				PlayerScript.score += scoreValue;
			}
		}
	}
}



