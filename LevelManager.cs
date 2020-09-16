using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void OnGameOpen()
    {
        SceneManager.LoadScene("Start");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}