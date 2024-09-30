using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ink.Runtime
{
    public class InkExternalFunctions : MonoBehaviour
{
    public TempObjective fairyRef;

    public PlayerStats heal;

    public NewDialogueManager manager;    

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

       story.BindExternalFunction ("addPoints", () =>
       {
           if(heal!=null)
           {
              heal.Heal(1f);
           }
          
       });


       
       story.BindExternalFunction ("IncreasePoints", (bool zero, bool one, bool two, bool three) =>
       {
          if(manager!=null)
          {
            manager.PointIncrease(zero, one, two, three);
          }
          
       });
       story.BindExternalFunction("HasPoints", () =>
       {
        manager.hasPoints = true;
       });
       
        story.BindExternalFunction("TurnOffPoints", () =>
        {
            manager.TurnOffPoints();
        }) ;

        


    }
}

}

