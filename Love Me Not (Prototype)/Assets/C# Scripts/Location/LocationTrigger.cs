using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LocationTrigger : MonoBehaviour
{
    [Header("Location Visual Cue")]
    [SerializeField] private GameObject locationVisualCue;
    
    private bool playerInRange;
    private void Awake()
    {
        playerInRange = false;
        locationVisualCue.SetActive(false);
    }

    private void Update()
    {
        if(playerInRange)
        {
            locationVisualCue.SetActive(true);
        }
        else
        {
            locationVisualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
       if(collider.gameObject.tag == "Player" )
       {
          playerInRange = false;
       }   
    }
}   
