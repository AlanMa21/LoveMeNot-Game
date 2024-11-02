using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPersistanceManager : MonoBehaviour
{
   public static DataPersistanceManager instance { get; private set;}

   [Header("Debugging")]
   [SerializeField] private bool initializeDataNull = false;
   [SerializeField] private bool disableDataPersistance = false;

   [Header("File Storage Config")]
   [SerializeField] private string fileName;
   [SerializeField] private bool overriderSelectedProfileId = false;
   [SerializeField] private string testSelectedProfileId = " test ";

   [Header("Auto Saving Configuration")]
   [SerializeField] private float autoSaveTimeSeconds = 60f;

   public GameData gameData;
   public List<IDataPersistance> dataPersistanceObjects = new List<IDataPersistance>();

   private FileDataHandler dataHandler;

   private string selectedProfileID = "";

   private Coroutine autoSaveCoroutine;
   public HealthBar healthBar;

   private void Awake()
   {

      if(instance != null)
      {
         Debug.LogError("More than 1 Data Persistance Manager found in the scene. Destroying the Newest one.");
         Destroy(this.gameObject);
         return;
      }
      instance = this;
      DontDestroyOnLoad(this.gameObject);

      if(disableDataPersistance)
      {
         Debug.LogWarning("DataPersistance is currently disabled!");
      }
      var temp = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();
      foreach(IDataPersistance a in temp)
      {
         dataPersistanceObjects.Add(a);
      }
      Debug.Log(dataPersistanceObjects.Count);
      this.dataHandler = new FileDataHandler(Application.streamingAssetsPath, fileName);
   
      /*this.selectedProfileID = dataHandler.GetMostRecentlyUpdatedProfileId();
      if (overriderSelectedProfileId)
      {
          this.selectedProfileID = testSelectedProfileId;
          Debug.LogWarning("overrode selected profile id with test id: " + testSelectedProfileId);
      }*/

      InitializeSelectedProfileId();
   }

   private void OnEnable()
   {

       SceneManager.sceneLoaded += OnSceneLoaded;

   }

   private void OnDisable()
   { 
      
      SceneManager.sceneLoaded -= OnSceneLoaded;
     
   }

   public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
   {
      Debug.Log("OnSceneLoaded");
      dataPersistanceObjects.Clear();
      var temp = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();
      foreach(IDataPersistance a in temp)
      {
         dataPersistanceObjects.Add(a);
      }
      Debug.Log(dataPersistanceObjects.Count + SceneManager.GetActiveScene().name);
      //this.dataPersistanceObjects = FindAllDataPersistanceObjects();
      LoadGame();
      // start up the auto saving coroutine 
      if ( autoSaveCoroutine != null)
      {
         StopCoroutine(autoSaveCoroutine);
      }
      autoSaveCoroutine = StartCoroutine(AutoSave());
   }

   public void DeleteProfileData(string profileId)
   {
      // delete the data for this profile id
      dataHandler.Delete(profileId);
      //initialize the selected profile id
      InitializeSelectedProfileId();
      //reload the game so that our data matches the newly selected profile id
      LoadGame();
   }

   private void InitializeSelectedProfileId()
   {
     this.selectedProfileID = dataHandler.GetMostRecentlyUpdatedProfileId();
      if (overriderSelectedProfileId)
      {
          this.selectedProfileID = testSelectedProfileId;
          Debug.LogWarning("overrode selected profile id with test id: " + testSelectedProfileId);
      }
   }

   /*public void OnSceneUnloaded(Scene scene)
   {
      Debug.Log("OnSceneUnloaded called");
      SaveGame();
   }*/

   public void ChangeSelectedProfileId(string newProfileId)
   {
      // update the profile to use for saving and loading
      this.selectedProfileID = newProfileId;
      // load the game, which will use that profile, updating our game data accordingly
      LoadGame();
   }
  
   public void NewGame()
   {
      this.gameData = new GameData(); 
   }

   public void LoadGame()
   {

      // return right away if data persistance is disabled
      if(disableDataPersistance)
      {
         return;
      }

      //Load any saved data from a file using the data handler
      //this.gameData = dataHandler.Load(selectedProfileID);

      //if no data can be loaded, initialize to new game
      if(this.gameData == null)
      {
          Debug.Log("No game data was found. A new game needs to be started before data can be loaded");
          return;
      }

      //Start a new game if data is null and we're configured to initialize data for debugging purposes
      if(this.gameData == null && initializeDataNull)
      {
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
      
      // return right away if data persistance is disabled
      if(disableDataPersistance)
      {
         return;
      }

      // if we don't have any data to save, log a warning here
      if (this.gameData == null)
      {
         Debug.LogWarning("No data was found. A New game need to be started before data can be saved.");
      }
      // pass the data to other scripts so they can update it
      Debug.Log(dataPersistanceObjects.Count);
      for(int i = 0; i < dataPersistanceObjects.Count; i++)
      {
         
         if(dataPersistanceObjects[i] != null)
         {
            dataPersistanceObjects[i].SaveData( gameData);
         }
         
      }

      // timestamp the data so we know when it was last saved
      gameData.lastUpdated = System.DateTime.Now.ToBinary();

      // save that to file using the data handler
      dataHandler.Save(gameData, selectedProfileID);
   }

   private void OnApplicationQuit()
   {
      SaveGame();
   }

   private List<IDataPersistance> FindAllDataPersistanceObjects()
   {
      IEnumerable<IDataPersistance> dataPersistancesOjects = new List<IDataPersistance>(FindObjectsOfType<MonoBehaviour>()
      .OfType<IDataPersistance>());
      return new List<IDataPersistance>(dataPersistancesOjects);
   }

   public bool HasGameData()
   {
       return gameData != null;
   }

   public Dictionary<string, GameData> GetAllProfilesGameData()
   {
       return dataHandler.LoadAllFiles();

   }

   private IEnumerator AutoSave()
   {
      while (true)
      {
          yield return new WaitForSeconds(autoSaveTimeSeconds);
          SaveGame();
          Debug.Log(" Auto Save Game ");
      }
   }
}
