using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using System.Linq;

public class DataPersistanceManager : MonoBehaviour
{
   public static DataPersistanceManager instace { get; private set;}

   private GameData gameData;
   private List<IDataPersistance> dataPersistancesObjects;

   private void Awake()
   {

      if(instace != null)
      {
         Debug.LogError("More than 1 Data Persistance Manager");
      }
      instace = this;
   }

   private void Start()
   {
      this.dataPersistancesObjects = FindAllDataPersistanceObjects();
      LoadGame();
   }

   public void NewGame()
   {
      this.gameData = new GameData(); 
   }

   public void LoadGame()
   {
      if(this.gameData == null)
      {
          Debug.Log("No game data was found.");
          NewGame();
      }
      
      // push the Loaded data to all other scripts that need it
      foreach (IDataPersistance dataPersistanceObj in dataPersistancesObjects)
      {
         dataPersistanceObj.LoadGame(gameData);
      }
   }

   public void SaveGame()
   {
      foreach (IDataPersistance dataPersistanceObj in dataPersistancesObjects)
      {
         dataPersistanceObj.SaveData(ref gameData);
      }
   }

   private void OnApplicationQuit()
   {
      SaveGame();
   }

   private List<IDataPersistance> FindAllDataPersistanceObjects()
   {
      IEnumerable<IDataPersistance> dataPersistancesOjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();

      return new List<IDataPersistance>(dataPersistancesObjects);
   }
}
