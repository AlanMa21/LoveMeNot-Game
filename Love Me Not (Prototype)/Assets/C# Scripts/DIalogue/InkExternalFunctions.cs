using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ink.Runtime
{
    public class InkExternalFunctions : MonoBehaviour
{
    public TempObjective fairyRef;

    public void Bind(Story story)
    {
        story.BindExternalFunction("loadNextLevel", (int buildIndex) => 
        {
            //Load Scene
            print("Switching Scene to " + buildIndex);
            SceneManager.LoadScene(buildIndex, LoadSceneMode.Single);
        
        });

        story.BindExternalFunction ("toggleFairy", () => 
        { 

            if (fairyRef!=null)
            {
                fairyRef.toggleFairy();
            }
            else
            {
                Debug.Log("ERROR - No reference to TempObjective script that activates fairy");
            }

        });
    }
}

}

