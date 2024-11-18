using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LocationTrigger : MonoBehaviour
{
   [Header("Location")]
   [SerializeField] private GameObject location;

   private bool inRange;

   private void Awake()
   {   
      
      location.SetActive(false);
   }

   private void update()
   {
      if(inRange)
      {
         location.SetActive(true);
        
      }
     
   }

   private void OnTriggerEnter2D(Collider2D collider)
   {
      if(collider.gameObject.tag == "Player")
      {
        inRange = true;
        Debug.Log("Im in");
      }
   }

   private void OnTriggerExit2D(Collider2D collider)
   {
      if(collider.gameObject.tag == "Player")
      {
        inRange = false;
      }
   }
}
 
