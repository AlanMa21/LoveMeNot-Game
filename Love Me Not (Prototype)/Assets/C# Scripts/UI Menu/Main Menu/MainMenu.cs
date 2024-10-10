using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    [Header("Menu Buttons")]
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueGameButton;
    //private int sceneToLoad;
    
    private void Start()
    {
        if(!DataPersistanceManager.instace.HasGameData())
        {
            continueGameButton.interactable = false;
        }
    }
    public void Playgame(int sceneToLoad)
    {
        SceneManager.LoadSceneAsync(sceneToLoad);
    }

    public void Exit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void OnNewGameClicked(int sceneLoaded)
    {
        DisableMenuButtons();
        Debug.Log("New Game Clicked");
        // Create a new game - which will initialize our game data
        DataPersistanceManager.instace.NewGame();
        SceneManager.LoadSceneAsync(sceneLoaded);
    }

    public void OnContinueGameClicked(int sceneLoaded)
    {
        DisableMenuButtons();
        Debug.Log("Continue Game");
        // Load the next scene - which will in turn load the game because of OnSceneLoaded() in the DataPersistanceManager
        SceneManager.LoadSceneAsync(sceneLoaded);

    }

    private void DisableMenuButtons()
    {
        newGameButton.interactable = false;
        continueGameButton.interactable = false;
    }

    

}   
