using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCoins, txtVictoryCondition;
    [SerializeField] GameObject victoryCondition;

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

   private static UIManager instace;

   public static UIManager MyInstance
   {
     get
     {
        if (instace == null)
            instace = new UIManager();

        return instace;
     }
   }

   public void AddCoins(int coins)
   {
     coins += coins;
     Debug.Log(coins);
   }

   public void UpdateCoinUI(int coins, int victoryCondition)
   {
     txtCoins.text = "Coins:" + coins + "/" + victoryCondition;
   }

   public void ShowVictoryCondition(int _coins, int _victoryCondition)
   {
     victoryCondition.SetActive(true);
     txtVictoryCondition.text = "You Need" + (_victoryCondition - _coins) + "More Coins";
   }

   public void HideVictoryCondition()
   {
     victoryCondition.SetActive(false);
   }

   
}
