using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDialogue : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
    }

    private void update()
    {
        if(playerInRange)
        {
            if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
            {
           
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
       if (collider.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

}
