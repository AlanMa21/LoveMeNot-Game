using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class DataPersistanceManager : MonoBehaviour
{

  [Header("File Storage Config")]
  [SerializeField] private string fileName;
   public static DataPersistanceManager instance {get; private set;}

   private GameData gameData;

   private List<IDataPersistance> dataPersistancesObjects;

   private FileDataHandler dataHandler;

   private void Start()
   { 

       this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
       this.dataPersistancesObjects = FindAllDataPersistanceObjects();
       LoadGame();
   }
   
   private void Awake()
   {
       if (instance != null)
       {
         Debug.LogError( "More than one Data Persistance Managr is found in the scene .");
       }
       instance = this;
   }

   public void NewGame()
   {
       this.gameData = new GameData();
   }

   public void LoadGame()
   {    
        this.gameData = dataHandler.Load();

        if (this.gameData == null)
        {
            Debug.Log("No data was found. Initialzing data to default.");
            NewGame();
        }

        foreach (IDataPersistance dataPersistanceObj in dataPersistancesObjects)
        {
            dataPersistanceObj.LoadData(gameData);
        }
   }

   public void SaveGame()
   {
      foreach(IDataPersistance dataPersistanceObj in dataPersistancesObjects)
      {
        dataPersistanceObj.SaveGame(ref gameData);
      }

      dataHandler.Save(gameData);


   }

   private void OnApplicationQuit()
   {
       SaveGame();

   }

   private List<IDataPersistance> FindAllDataPersistanceObjects()
   {
     IEnumerable<IDataPersistance> dataPersistanceManagersOjects = FindObjectsOfType<MonoBehaviour>()
      .OfType<IDataPersistance>();

     return new List<IDataPersistance>(dataPersistancesObjects);
   }
   
   

}
