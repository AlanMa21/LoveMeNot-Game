using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveSlotsMenu : Menu
{

   [Header("Menu Button")]
   [SerializeField] private Button backButton;

   [Header("Menu Navigation")]
   [SerializeField] private MainMenu mainMenu;
   private SaveSlot[] saveSlots;

   private bool isLoadingGame = false;

   private void Awake()
   {
      saveSlots = this.GetComponentsInChildren<SaveSlot>();
   }

   public void OnBackClicked()
   {
      mainMenu.ActivateMenu();
      this.DeactivateMenu();
   }

   public void OnSaveSlotClicked(SaveSlot saveslot)
   {
      // Disable all buttons
      DisableMenuButton();

      // update the seletced profile ID to be used for data persistance
      DataPersistanceManager.instance.ChangeSelectedProfileId(saveslot.GetProfileId());

      if(!isLoadingGame)
      {
         //create a new game - which will initialze our data to a clean state
      DataPersistanceManager.instance.NewGame();

      }

      // save the game anytime before loading a new scene
      DataPersistanceManager.instance.SaveGame();
      
       // Load the scene - which will in turn save the game because of OnSceneUnloaded() in the DataPersistanceManager
      SceneManager.LoadSceneAsync(3);
      
   }

   public void OnClearClicked(SaveSlot saveSlot)
   {
      DataPersistanceManager.instance.DeleteProfileData(saveSlot.GetProfileId());
      ActivateMenu(isLoadingGame);
   }

   public void ActivateMenu(bool isLoadingGame)
   {
      // set this menu to be active
      this.gameObject.SetActive(true);

      // Set Mode
      this.isLoadingGame = isLoadingGame;

      // load all of the profiles that exist
      Dictionary<string, GameData> profilesGameData = DataPersistanceManager.instance.GetAllProfilesGameData();

      // loop through each save slot in the UI and set the content appropriately
      GameObject firstSelected = backButton.gameObject;
      foreach (SaveSlot saveSlot in saveSlots)
      {
         GameData profileData = null;
         profilesGameData.TryGetValue(saveSlot.GetProfileId(), out profileData);
         saveSlot.SetData(profileData);
         if(profileData == null && isLoadingGame)
         {
             saveSlot.SetInteractable(false);
         }
         else
         {
            saveSlot.SetInteractable(true);
            if(firstSelected.Equals(backButton.gameObject))
            {
               firstSelected = saveSlot.gameObject;
            }
         }
         
      }

      //set the first selected button
      Button firstSelectedButton = firstSelected.GetComponent<Button>();
      this.SetFirstSelected(firstSelectedButton);
   }
   
   public void DeactivateMenu()
   {
      this.gameObject.SetActive(false);
   }

   private void DisableMenuButton()
   {
      foreach (SaveSlot saveSlot in saveSlots)
      {
          saveSlot.SetInteractable(false);
      }
      backButton.interactable = false;
   }
   
}
