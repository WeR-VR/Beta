using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
	public float startSpawn;
	public float endSpawn;
	public GameObject enemy;
	GameObject soldierSpawn;
	// Use this for initialization
	void Start () {
		CreatePrefab ();
		InvokeRepeating ("CreatePrefab", startSpawn, endSpawn);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreatePrefab(){
		soldierSpawn = Instantiate (enemy, transform.position, Quaternion.identity) as GameObject;
	}
}
