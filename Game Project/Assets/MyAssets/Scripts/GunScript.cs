using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public bool isFiring;
	public BulletScript bullet;
	public float bulletSpeed;
	public float timeBetweenShots;

	private float shotCounter;
	public Transform firePoint;
	public AudioSource shots;

	// Use this for initialization
	void Start () {
		AudioSource shots = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(isFiring)
		{
			

			shotCounter -= Time.deltaTime;
			if (shotCounter <=0)
			{
				shotCounter = timeBetweenShots;
				BulletScript newBullet = Instantiate(bullet, firePoint.position,firePoint.rotation) as BulletScript;
				newBullet.speed = bulletSpeed;
				shots.Play ();
			}
		} 
		else {
			shotCounter = 0;

		}


	}
}
