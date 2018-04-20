using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuScript : MonoBehaviour {
	public Canvas gameMenu;
	public Canvas quitMenu;
	public Canvas TimeMenu;
	public Canvas HealthMenu;

	public Text backIngame;
	public Text textTime;
	public Canvas defendUpgrade;
	public Canvas healthUpgrade;
	public float timeRemaining = 120;

	// Use this for initialization
	void Start () {
		gameMenu = gameMenu.GetComponent<Canvas> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();
		TimeMenu = TimeMenu.GetComponent<Canvas> ();
		HealthMenu = HealthMenu.GetComponent<Canvas> ();
		defendUpgrade = defendUpgrade.GetComponent<Canvas> ();
		healthUpgrade = healthUpgrade.GetComponent<Canvas> ();
		backIngame = backIngame.GetComponent<Text> ();
		textTime = textTime.GetComponent<Text> ();

		//UpGrades



		gameMenu.enabled = true;
		quitMenu.enabled = false;
		TimeMenu.enabled = false;
		defendUpgrade.enabled = false;
		healthUpgrade.enabled = false;
		HealthMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;

		if (timeRemaining > 0) {
			textTime.text = "Defend Time: " + timeRemaining;
		} 
		else{
			textTime.text = "Reinforcements arrived!";
		TimeMenu.enabled = true;
		}
		if (PlayerScript.score >= 50) {
			defendUpgrade.enabled = true;
		}
		if (PlayerScript.score >= 150) {
			healthUpgrade.enabled = true;
		}

		if (PlayerScript.health <= 0) {
			HealthMenu.enabled = true;
		}


	
	}
		
	public void quitOption()
	{
		Application.LoadLevel (0);
	}

	public void quitToMain()
	{
		quitMenu.enabled = true;
	}

	public void returnTogame()
	{
		quitMenu.enabled = false;

	}

	public void gameRestart(){
		Application.LoadLevel (1);
	}



	//if time = 0 bring up canvas for game over
}
