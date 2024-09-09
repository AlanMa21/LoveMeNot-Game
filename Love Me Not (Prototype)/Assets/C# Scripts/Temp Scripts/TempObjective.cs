using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class TempObjective : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> QuestRequirements;

    [Header("Ink JSON")]
    [SerializeField] private Container inkFile;

    [Header ("Activated Game Objects With Interaction")]
    [SerializeField]
    private GameObject activateOnComplete;
  
    
    [Space(20)]

    [SerializeField]
    private int numberOfCompleted = 0;

    [SerializeField]
    private int numberRequired;
    public Story myStory;

    
    void Awake()
    {
        myStory = new Story(inkFile);
    }
    

    void Start()
    {
        myStory.BindExternalFunction ("activateFairy", () => 
        { 
            toggleFairy();

        });

        numberRequired = QuestRequirements.Count;

       



    }

    public bool AttemptCompletion()
    {
        
        foreach(GameObject g in QuestRequirements)
        {
            if (g.GetComponentInChildren<NewDialogueTrigger>() != null)
            {
                NewDialogueTrigger dT = g.GetComponentInChildren<NewDialogueTrigger>();
                if (dT.interactionCount > 0)
                {
                    numberOfCompleted ++;

                Debug.Log(g.name + " has been interacted with. yippee! total count is: " + numberOfCompleted);
                }
            }
            


            /*
            TempInteractable tI = g.GetComponent<TempInteractable>();

            if (tI.hasBeenActivated)
            {
                numberOfCompleted ++;

                Debug.Log(tI.gameObject.name + " has been interacted with. yippee! total count is: " + numberOfCompleted);
            }
            */
        }

        if (numberOfCompleted >= numberRequired)
        {
            Debug.Log("interaction allowed");

            //toggleFairy();

            return true;

            // Allow interaction
        }
        else
        {
            Debug.Log("interaction denied");
            return false;
            // Deny interaction
        }
    }

    public void toggleFairy()
    {
        if (activateOnComplete!= null)
        {
            if(activateOnComplete.activeInHierarchy == false)
            {
                activateOnComplete.SetActive(true);
            }
            else
            {
                activateOnComplete.SetActive(false);
            }
        }
        
        
    }

   

}
