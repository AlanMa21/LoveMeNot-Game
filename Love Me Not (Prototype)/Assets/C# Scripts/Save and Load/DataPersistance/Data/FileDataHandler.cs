using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using JetBrains.Annotations;

public class FileDataHandler
{
    private string dataDirthPath = "L:/";
    private string dataFileName = "data";
    
    public FileDataHandler(string dataDirthPath, string dataFileName)
    {
        this.dataDirthPath = dataDirthPath;
        this.dataFileName = dataFileName;
    }

    public GameData Load(string profileId)
    {
        // use Path.Combine to account for the different OS's having different path separators
        string fullPath = Path.Combine(dataDirthPath, profileId, dataFileName);
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

    public void Save(GameData data, string profileId)
    {
        // use Path.Combine to account for the different OS's having different path separators
        string fullPath = Path.Combine(dataDirthPath, profileId, dataFileName);
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

    public Dictionary<string, GameData> LoadAllFiles()
    {
        Dictionary<string, GameData> profileDictionary = new Dictionary<string, GameData>();

        // loop over all directory names in the data directory path
        IEnumerable<DirectoryInfo> dirInfos = new DirectoryInfo(dataDirthPath).EnumerateDirectories();
        foreach (DirectoryInfo dirInfo in dirInfos)
        {
            string profileId = dirInfo.Name;
            // defensive programming-  check if the datat file exsists
            // if it doesn't then this folder isn't a profile and should be skipped
            string fullPath = Path.Combine(dataDirthPath, profileId, dataFileName);
            if(!File.Exists(fullPath))
            {
                Debug.LogWarning("Skipping directory when loading all profiles because it does not contain data:"
                + profileId);
                continue;
            }

            //load the game data for this profile and put it in the dictionary
            GameData profileData =  Load(profileId);
            // defensive programming - ensuring the profile data isn't null
            // because if it is then something went wrong and we should let oursleves know
            if (profileData !=null)
            {
                profileDictionary.Add(profileId, profileData);
            }
            else
            {
                Debug.LogError("Tried to load profile but something went wrong. ProfileId :" + profileId);
            }
        }

        return profileDictionary;
    }
}
