using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameData 
{

  public long lastUpdated;
  public float playerPoints;

  public Vector2 playerPosition;

  

  
  
  // the values defined in this constructor will be the default values 
  // the game starts with when there's no data to load
   public GameData()
   {
      this.playerPoints = 0f;
      playerPosition = Vector2.zero;
      SceneManager.LoadSceneAsync(0);

   }
}
