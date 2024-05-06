using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public int collectedCoins, victoryCondition = 2;
   public GameObject _victoryCondition;

   private void Awake()
   {
     if (instace == null)
     {
         instace = this;
     }
     else
     {
        DestroyImmediate(this);
     }
   }

   private static GameManager instace;

   public static GameManager MyInstance
   {
     get
     {
        if (instace == null)
            instace = new GameManager();

        return instace;
     }
   }

   private void Start()
   {
     UIManager.MyInstance.UpdateCoinUI(collectedCoins,victoryCondition);
   }

   public void AddCoins(int coins)
   {
     collectedCoins += coins;
     UIManager.MyInstance.UpdateCoinUI(collectedCoins,victoryCondition);
   }

   public void Finish()
   {
     Debug.Log("A");
     if (collectedCoins >= victoryCondition)
     {
        SceneManager.LoadScene(0);
     }
     else
     {
        UIManager.MyInstance.ShowVictoryCondition(collectedCoins, victoryCondition);
     }
   }
}
