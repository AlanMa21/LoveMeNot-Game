using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
     [SerializeField] private float maxHealth;
     [SerializeField] private float minHealth;
     private float currentHealth;

     public HealthBar healthBar;
    
     private void Start()
     {
        currentHealth = minHealth;

        healthBar.SetSliderMax(maxHealth);
        healthBar.SetSliderMin(minHealth);
       
     }

     public void TakeDamage(float amount)
     {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
     }

     public void Heal(float amount)
     {
         currentHealth += amount;
         healthBar.SetSlider(currentHealth);
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
}
