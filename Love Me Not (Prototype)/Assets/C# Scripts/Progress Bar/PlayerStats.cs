using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.EventSystems;
using Ink.Parsed;

public class PlayerStats : MonoBehaviour, IDataPersistance
{
     [SerializeField] private float maxHealth;
     [SerializeField] private float minHealth;

     private float currentHealth;

     public HealthBar healthBar;

    private InkExternalFunctions externalFunctions;

    private NewDialogueManager dM;

    public void LoadData(GameData data)
    {
       this.currentHealth = DataPersistanceManager.instance.gameData.healthSlider;
       if(healthBar != null)
       {
         if(healthBar != DataPersistanceManager.instance.healthBar)
          {
            healthBar = DataPersistanceManager.instance.healthBar;
         }
       }
       
       Debug.Log(data.playerPoints);
    }

    public void SaveData(GameData data)
    {
       DataPersistanceManager.instance.gameData.healthSlider = this.currentHealth;
       data.playerPoints = 10;
    } 

     
    
     private void Start()
     {
        //currentHealth = minHealth;
        if(healthBar != null)
        {
         healthBar.SetSliderMax(maxHealth);
        healthBar.SetSliderMin(minHealth);
        }
        
       
     }

     public void TakeDamage(float amount)
     {
      if(currentHealth >= minHealth)
      {
         currentHealth -= amount;
         healthBar.SetSlider(currentHealth);
         DataPersistanceManager.instance.gameData.healthSlider = currentHealth;
      }
        
     }

     public void Heal(float amount)
     {
      if(currentHealth <= maxHealth)
      {
         Debug.Log("EEEE");
         currentHealth += amount;
         healthBar.SetSlider(currentHealth);
         DataPersistanceManager.instance.gameData.healthSlider = currentHealth;
      }
         
     }

     public void Update()
     {
         if(Input.GetKeyDown(KeyCode.K))
         {
            TakeDamage(1f);
         }

         if(Input.GetKeyDown(KeyCode.L))
         {
            Heal(1f);
         }


         if(currentHealth == maxHealth)
         {
            Debug.Log("Well Done, you're in Love Owo");
         }  
     }

     private void StopTakingDamage()
     {
       if(currentHealth ==  minHealth)
       {
          
       }
     }

   

    
}
