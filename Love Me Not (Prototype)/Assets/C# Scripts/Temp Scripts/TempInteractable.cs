using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TempInteractable : MonoBehaviour
{
    public bool hasBeenActivated;
    public bool canBeInteractedWith;

    void Start()
    {
        canBeInteractedWith = true;
    }
    public void InteractWith()
    {
        if (!hasBeenActivated)
        {
            // Start dialogue 
            hasBeenActivated = true;
            Debug.Log("Player interacted with "+ gameObject.name);
            canBeInteractedWith = false;
        }
        else
        {
            Debug.Log("Player Attempted Interaction with '"+gameObject.name+"'], but this has already been interacted with");
            // Start already interacted outcome dialogue
        }
    }
}
