using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SaveManager : MonoBehaviour
{
    private BreadMovement _bread;
    private void Awake()
    {
        _bread = GameObject.FindObjectOfType<BreadMovement>();
        Load();
    }
   public void Save()
   {
       
       Debug.Log("Saving!");
       //Create a file or open a file to save to
       FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate);

       try
       {
             //Binary Formater -- allows us to write data to file
               BinaryFormatter formatter = new BinaryFormatter();

              //Serialization method to WRITE to the file
              formatter.Serialize(file, _bread.myStats);
       
       }
       catch (SerializationException e)
       {
             Debug.LogError("There was an issue serializing this data:" + e.Message);
       }
       finally
       {
           file.Close();
       }

      
   }

   public void Load()
   {
      FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);

      try
      {
           BinaryFormatter formatter = new BinaryFormatter();
          _bread.myStats = (Stats) formatter.Deserialize(file);

      }
      catch(SerializationException e)
      {
         Debug.LogError("Error Deserializating Data" + e.Message);
      }
      finally
      {
         file.Close();
      }
      

     
   }
}
