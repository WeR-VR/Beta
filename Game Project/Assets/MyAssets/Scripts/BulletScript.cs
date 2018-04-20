using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public float speed = 5;
	public float seconds;

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, seconds);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Untagged") {
			Destroy(this.gameObject);

		}
}
}

