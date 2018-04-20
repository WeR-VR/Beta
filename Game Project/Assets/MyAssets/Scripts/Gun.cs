using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour {
	public GameObject BulletPrefab;

    public Transform bulletSpawn;

    public  float   damage = 15f;
	public  float   burstdamage =30f;
    public  float   range = 100f;
    private float   bullets = 10f;
    public  Text    BulletText;
    public  float   Health = 100f;
    public  Camera  fpscam;
    public  Image   HealthBar;



    // Update is called once per frame
    void Update()
    {
        bullets = Mathf.Clamp(bullets, 0f, Mathf.Infinity);
        BulletText.text = string.Format("{0:00}", bullets);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
      
        if (Input.GetKeyDown(KeyCode.R) || Input.GetButton("Xbox_X"))
        {
            Reload();
        }
       
        if (bullets == 0)
        {
            BulletText.color = Color.red;
            BulletText.text = "Reload";
        }
    }

    private void Reload()
    {
        Debug.Log("Reloading");
        //TODO: Add Delay Function
        Debug.Log("Reloading Complete!");
        //TODO: Add Delay Function
        BulletText.color = Color.cyan;
        bullets = 10f;
    }

    private void Shoot()
    {
        if (bullets > 0)
        {
            Instantiate(BulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.takeDam(damage);
                }
            }
            bullets--;
        }
        else
        {
            Debug.Log("Reload");
        }
    }

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health = Health - 20;
			HealthBar.fillAmount = Health/100f;
            if (Health <= 0)
            {
                //dead.Play ();
                //PlayerScript.score += scoreValue;
                SceneManager.LoadScene(0);
            }
        }
	}
    public float GetHealth(float health)
    {
        health = Health;
        return health;
    }
    
}
