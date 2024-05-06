using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.InputSystem;

public class NewDialogueTrigger : MonoBehaviour
{
  [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("My Story")]
    [SerializeField] private Story myStory;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Denied Ink JSON")]
    [SerializeField] private TextAsset deniedInkJSON;

    private bool playerInRange;

    [SerializeField]
    private int interactionCount;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);

        interactionCount = 0;

        
    }
    
    private void Update()
    {
        if (playerInRange && !NewDialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                
                //NewDialogueManager.GetInstance().EnterDialogueMode(inkJSON);

                if(gameObject.transform.parent.GetComponent<TempInteractable>() != null)
                {
                    TempInteractable tI = gameObject.transform.parent.GetComponent<TempInteractable>();

                    if (tI.canBeInteractedWith)
                    {
                        tI.InteractWith(); 

                        EnterDialogue();
                        //NewDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                    }                    
                }

                if(gameObject.transform.parent.GetComponent<TempObjective>() != null)
                {
                    TempObjective tO = gameObject.transform.parent.GetComponent<TempObjective>();


                    bool canInteract = tO.AttemptCompletion();

                    if (canInteract)
                    {
                        EnterDialogue();
                        //NewDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                    }

                    
                              
                }
                else
                {
                    EnterDialogue();
                    //NewDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                }
            }

        }
        else
        {
            visualCue.SetActive(false);
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

    private void EnterDialogue()
    {
        interactionCount++;
        NewDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
