using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPersistanceManager : MonoBehaviour
{
   public static DataPersistanceManager instace { get; private set;}

   [Header("File Storage Config")]
   [SerializeField] private string fileName;

   private GameData gameData;
   private List<IDataPersistance> dataPersistanceObjects;

   private FileDataHandler dataHandler;

   private void Awake()
   {

      if(instace != null)
      {
         Debug.LogError("More than 1 Data Persistance Manager");
      }
      instace = this;

      this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
   }

   private void OnEnable()
   {
      SceneManager.sceneLoaded += OnSceneLoaded;
      SceneManager.sceneUnloaded += OnSceneUnloaded;

   }

   private void OnDisable()
   {
      SceneManager.sceneLoaded -= OnSceneLoaded;
      SceneManager.sceneUnloaded -= OnSceneUnloaded;
   }

   public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
   {
      Debug.Log("OnSceneLoaded");
      this.dataPersistanceObjects = FindAllDataPersistanceObjects();
      LoadGame();
   }

   public void OnSceneUnloaded(Scene scene)
   {
      Debug.Log("OnSceneUnloaded called");
      SaveGame();
   }
  
   public void NewGame()
   {
      this.gameData = new GameData(); 
   }

   public void LoadGame()
   {
      //Load any saved data from a file using the data handler
      this.gameData = dataHandler.Load();

      //if no data can be loaded, initialize to new game
      if(this.gameData == null)
      {
          Debug.Log("No game data was found.");
          NewGame();
      }
      
      // push the Loaded data to all other scripts that need it
      foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
      {
         dataPersistanceObj.LoadData(gameData);
      }
   }

   public void SaveGame()
   {
      // pass the data to other scripts so they can update it
      foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
      {
         dataPersistanceObj.SaveData(ref gameData);
      }

      // save that to file using the data handler
      dataHandler.Save(gameData);
   }

   private void OnApplicationQuit()
   {
      SaveGame();
   }

   private List<IDataPersistance> FindAllDataPersistanceObjects()
   {
      IEnumerable<IDataPersistance> dataPersistancesOjects = FindObjectsOfType<MonoBehaviour>()
      .OfType<IDataPersistance>();

      return new List<IDataPersistance>(dataPersistanceObjects);
   }
}
