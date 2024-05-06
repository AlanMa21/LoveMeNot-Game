using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Exit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}