using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSlotsMenu : MonoBehaviour
{
   private SaveSlot[] saveSlots;

   private void Awake()
   {
      saveSlots = this.GetComponentsInChildren<SaveSlot>();
   }

   private void Start()
   {
      ActivateMenu();
   }

   public void ActivateMenu()
   {
      // load all of the profiles that exist
      Dictionary<string, GameData> profilesGameData = DataPersistanceManager.instace.GetAllProfilesGameData();

      // loop through each save slot in the UI and set the content appropriately

      foreach (SaveSlot saveSlot in saveSlots)
      {
         GameData profileData = null;
         profilesGameData.TryGetValue(saveSlot.GetProfileId(), out profileData);
         saveSlot.SetData(profileData);
         
      }
   }
}
