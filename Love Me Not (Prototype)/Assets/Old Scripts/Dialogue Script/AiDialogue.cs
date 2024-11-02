using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class AiDialogue : MonoBehaviour
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
    public int interactionCount;
    public bool isPassiveDialogue;

    public NewDialogueManager dM_Backup;
    public BreadMovement player;

    

    [SerializeField] private bool NonNarrativeFunction;

    private void Awake()
    {
        playerInRange = false;

        if(visualCue!=null)
        {
            visualCue.SetActive(false);
        }

        interactionCount = 0;

        /*if (isPassiveDialogue)
        {
            StartCoroutine(StartPassiveDialogue());
            Debug.Log("entering passive dialogue");
        }*/

        
    }
    
    private void Update()
    {
        /*if(gameObject.transform.parent.GetComponent<TempInteractable>() != null)
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
                }*/
       
       
    }

    private void EnterDialogue()
    {
        interactionCount++;
        if (NonNarrativeFunction)
        {
            // this is a bit brute forced but can be updated later
            if (gameObject.GetComponent<SceneTransition>()!= null)
            {
                gameObject.GetComponent<SceneTransition>().SwitchScene();
            }
        }
        else
        {            
            NewDialogueManager dM = NewDialogueManager.GetInstance();
            if (dM == null)
            {
                dM = dM_Backup;
            }

            dM.EnterDialogueMode(inkJSON, true);
        }
        
    }

     private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            EnterDialogue();
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
