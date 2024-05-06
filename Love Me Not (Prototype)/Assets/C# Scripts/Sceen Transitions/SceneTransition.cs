using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
   public int sceneBuildIndex;
   public bool checkForComplete;

   private void OnTriggerEnter2D(Collider2D other)
   {
         print("Trigger Entered");

         if(other.tag == "Player")
         {
            if (checkForComplete && gameObject.GetComponent<TempObjective>() != null)
            {
               TempObjective tO = gameObject.GetComponent<TempObjective>();
               bool willSwitch = tO.AttemptCompletion();
               if (willSwitch)
               {
                  SwitchScene();
               }
               else
               {
                  return;
               }
            }
            else
            {
               SwitchScene();
            }
         }
   }

   public void SwitchScene()
   {
      print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
   }
}
