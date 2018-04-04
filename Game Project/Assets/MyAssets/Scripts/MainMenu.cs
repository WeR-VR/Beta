using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private void Update()
    {
        GetKeyInputs();
    }
    private void GetKeyInputs()
    {
        if (Input.GetButton("Xbox_Start") || Input.GetKeyDown(KeyCode.Return))
            Play();
        if (Input.GetButton("Xbox_Back") || Input.GetKeyDown(KeyCode.Escape))
            Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }
    public void HowToPlay()
    {
        Debug.Log("HowToPlay");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
