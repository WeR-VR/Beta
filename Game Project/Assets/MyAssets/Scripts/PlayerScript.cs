using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	public float speed;
	private Rigidbody myRigidbody;
	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;
	public GunScript theGun;

	public static int score;
	public static int health;
	public Text textScore; 
	public Text textHealth;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		mainCamera = FindObjectOfType<Camera> ();
		textScore = textScore.GetComponent <Text> ();
		score = 0;
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayLength;

		if (groundPlane.Raycast (cameraRay, out rayLength)) {
			Vector3 pointToLook = cameraRay.GetPoint (rayLength);

			Debug.DrawLine(cameraRay.origin,pointToLook, Color.red);

			transform.LookAt (new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
		}

		if (Input.GetMouseButtonDown (0))
			theGun.isFiring = true;

		if (Input.GetMouseButtonUp (0))
			theGun.isFiring = false;
		
		textScore.text = "Score: " + score;
		textHealth.text = "Health: " + health;
	}

void OnTriggerEnter(Collider other){
	if (other.gameObject.tag == "Bullet") {
				//Destroy(this.gameObject);
			health = health - 6;
		}
	}

}
