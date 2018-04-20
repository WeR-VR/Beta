using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Canvas mainMenu;
	public Canvas instrucPage;
	public Canvas instrucPageTwo;
	public Canvas creditMenu;
	public Text start;
	public Text instructions;
	public Text quit;
	public Text back;



	// Use this for initialization
	void Start () {
		mainMenu = mainMenu.GetComponent<Canvas> ();
		instrucPage = instrucPage.GetComponent<Canvas> ();
		instrucPageTwo = instrucPageTwo.GetComponent<Canvas> ();
		creditMenu = creditMenu.GetComponent<Canvas> ();
		start = start.GetComponent<Text> ();
		instructions = instructions.GetComponent<Text> ();
		quit = quit.GetComponent<Text> ();
		back = back.GetComponent<Text> ();
		mainMenu.enabled = true;
		instrucPage.enabled = false;
		instrucPageTwo.enabled = false;
		creditMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(){

		Application.LoadLevel (1);
	}

	public void quitGame(){
		Application.Quit ();
	}

	public void pageInstructions(){
		mainMenu.enabled = false;
		instrucPage.enabled = true;
		instrucPageTwo.enabled = false;
		creditMenu.enabled = false;
	}

	public void pageInstructionsTwo(){
		mainMenu.enabled = false;
		instrucPage.enabled = false;
		instrucPageTwo.enabled = true;
		creditMenu.enabled = false;
	}
	public void backToMenu(){
		mainMenu.enabled = true;
		instrucPage.enabled = false;
		creditMenu.enabled = false;
	}

	public void CreditMenu(){
		creditMenu.enabled = true;
	}
}
