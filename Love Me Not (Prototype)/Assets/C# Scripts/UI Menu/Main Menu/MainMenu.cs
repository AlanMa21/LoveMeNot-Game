using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //private int sceneToLoad;
    public void Playgame(int sceneToLoad)
    {
        SceneManager.LoadSceneAsync(sceneToLoad);
    }

    public void Exit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
