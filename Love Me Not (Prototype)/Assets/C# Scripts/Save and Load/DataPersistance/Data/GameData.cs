using System.Collections;
using System.Collections.Generic;
using Ink.Runtime;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class GameData 
{

  public long lastUpdated;
  public float playerPoints;

  public Vector2 playerPosition;

  public Slider healthSlider;

  

  
  
  // the values defined in this constructor will be the default values 
  // the game starts with when there's no data to load
   public GameData()
   {
      this.playerPoints = 0f;
      playerPosition = Vector2.zero;
      //this.healthSlider.value = ;
      

   }
}
