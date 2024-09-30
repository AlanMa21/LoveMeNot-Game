using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string dataDirthPath = "C:/";
    private string dataFileName = "data";
    
    public FileDataHandler(string dataDirthPath, string dataFileName)
    {
        this.dataDirthPath = dataDirthPath;
        this.dataFileName = dataFileName;
    }

    public GameData Load()
    {
        // use Path.Combine to account for the different OS's having different path separators
        string fullPath = Path.Combine(dataDirthPath, dataDirthPath);
        GameData loadedData = null;
        if(File.Exists(fullPath))
        {
            try
            {
               //Load the serialized data from the file
               string dataToLoad = "";
               using (FileStream stream= new FileStream(fullPath, FileMode.Open))
               {
                 using (StreamReader reader = new StreamReader(stream))
                 {
                    dataToLoad = reader.ReadToEnd();
                 }
               }
               // deserialize the data from Json back into the C# object
               loadedData = JsonUtility.FromJson<GameData>(dataToLoad);

            }
            catch (Exception e)
            {
                Debug.Log("Error occured when trying to load data from file:" + fullPath + "/n" + e);
            }
        }
        return loadedData;
    }

    public void Save(GameData data)
    {
        // use Path.Combine to account for the different OS's having different path separators
        string fullPath = Path.Combine(dataDirthPath, dataFileName);
        try
        {
           //create the directory the file will be written to if it doesn't already exist
           string a = Directory.CreateDirectory(Path.GetDirectoryName(fullPath)).Name;
           Debug.Log(a);

           //serialize the C# game data object into JSON
           string dataToStore = JsonUtility.ToJson(data, true);

           //write the serialized data to the file
           using (FileStream stream = new FileStream(fullPath, FileMode.Create))
           {
              using (StreamWriter writer = new StreamWriter(stream))
              {
                Debug.Log(writer);
                 writer.Write(dataToStore);
              }
           }
        }
        catch (Exception e)
        {
            Debug.Log("Error occured when trying to save data to file: " + fullPath + "/n" + e);
        }
    }
}
