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
            spawnFairy();

        });

        numberRequired = QuestRequirements.Count;
    }

    public bool AttemptCompletion()
    {
        
        foreach(GameObject g in QuestRequirements)
        {

            TempInteractable tI = g.GetComponent<TempInteractable>();

            if (tI.hasBeenActivated)
            {
                numberOfCompleted ++;

                Debug.Log(tI.gameObject.name + " has been interacted with. yippee! total count is: " + numberOfCompleted);
            }
        }

        if (numberOfCompleted >= numberRequired)
        {
            Debug.Log("interaction allowed");

            /*
            if(activateOnComplete!=null)
                {
                    activateOnComplete.SetActive(true);
                }
            */

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

    public void spawnFairy()
    {
        if (activateOnComplete!= null)
        {
            activateOnComplete.SetActive(true);
        }
        
    }
}
