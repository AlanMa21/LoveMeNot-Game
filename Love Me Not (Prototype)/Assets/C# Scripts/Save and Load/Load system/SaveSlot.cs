using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveSlot : MonoBehaviour
{
      [Header("Profile")]
      [SerializeField] private string profileId = "";
      [Header("Content")] 
      [SerializeField] private GameObject noDataContent;
      [SerializeField] private GameObject hasDataContent;

      [Header("Clear Data Button")]
      [SerializeField] private Button clearButton;

   

      private Button saveSlotButton;

      private void Awake()
      {
         saveSlotButton = this.GetComponent<Button>();
      }
    

      public void SetData(GameData data)
      {
         //there is not data for this profileId
         if (data == null)
         {
             noDataContent.SetActive(true);
             hasDataContent.SetActive(false);
             clearButton.gameObject.SetActive(false);
         }
         // there is not data for this profileId
         else
         {
            
             noDataContent.SetActive(false);
             hasDataContent.SetActive(true);
             clearButton.gameObject.SetActive(true);
         }
      }

      public string GetProfileId()
      {
         return this.profileId;
      }

      public void SetInteractable(bool interactable)
      {
         saveSlotButton.interactable = interactable;
         clearButton.interactable = interactable;
      }
     
     
  
   
}
