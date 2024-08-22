using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Ink;
using System.Runtime.Serialization;
public class SaveManager : MonoBehaviour

{
    private ProgressBar bar;

    private void Awake()
    {
        bar = GameObject.FindObjectOfType<ProgressBar>();
       
       
    }
    public void Save()
    {
        Debug.Log("Saving!");
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate);

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, bar.myStats);
        }
        catch (SerializationException e)
        {
            Debug.LogError("There was an isusse serizalizing this data:" + e.Message);

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
            bar.myStats = (Stats) formatter.Deserialize(file);
        }
        catch(SerializationException e)
        {
            Debug.LogError("Error Deserializing Data:" + e.Message);
        }
        finally
        {
            file.Close();
        }
      

       
    }
}
