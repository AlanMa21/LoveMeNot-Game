using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : Menu
{
    [Header("Menu Navigation")]
    [SerializeField] private SaveSlotsMenu saveSlotsMenu;
    [Header("Menu Buttons")]
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueGameButton;
    //private int sceneToLoad;
    [SerializeField] private Button loadGameButtion;
    
    private void Start()
    {
        DisableMenuButtonDependingOnData();
    }

    private void DisableMenuButtonDependingOnData()
    {
         if(!DataPersistanceManager.instance.HasGameData())
        {
            continueGameButton.interactable = false;
            loadGameButtion.interactable = false;
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
       saveSlotsMenu.ActivateMenu(false);
       this.DeactivateMenu();
    }

    public void OnLoadGameClicked()
    {
        saveSlotsMenu.ActivateMenu(true);
        this.DeactivateMenu();
    }

    public void OnContinueGameClicked(int sceneLoaded)
    {
        DisableMenuButtons();
        // save the game anytime before loading a new scene
        DataPersistanceManager.instance.SaveGame();
        Debug.Log("Continue Game");
        // Load the next scene - which will in turn load the game because of OnSceneLoaded() in the DataPersistanceManager
        SceneManager.LoadSceneAsync(sceneLoaded);

    }

    private void DisableMenuButtons()
    {
        newGameButton.interactable = false;
        continueGameButton.interactable = false;
    }

    public void ActivateMenu()
    {
       this.gameObject.SetActive(true);
       DisableMenuButtonDependingOnData();
    }

    public void DeactivateMenu()
    {
       this.gameObject.SetActive(false);
    }

    

}   
