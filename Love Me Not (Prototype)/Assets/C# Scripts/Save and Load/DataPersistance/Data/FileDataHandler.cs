using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using JetBrains.Annotations;
using UnityEngine.InputSystem;

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
        //base case - if the profileId is null, return right away
        if (profileId == null)
        {
            return null;
        }

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

        // base case - if the profileId is null, return rigth away
        if(profileId == null)
        {
           return;
        }
        
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

    public void Delete(string profileId)
    {
        // base case - if the profileId is null, return rigth away
        if (profileId == null)
        {
            return;
        }

        string fullPath = Path.Combine(dataDirthPath, profileId, dataFileName);
        try
        {
            // ensure the data file exists at this path before deleting the directory
            if(File.Exists(fullPath))
            {
                //delete the profile folder and everything within in
                Directory.Delete(Path.GetDirectoryName(fullPath), true);
            }
            else
            {
                 Debug.LogWarning(" Tried to delete profile data, but data was not found at path: " + fullPath);
            }
        }
        catch (Exception e)
        {
           Debug.LogError(" Failed to delete profile data for profileId: " + profileId + " at path " + fullPath + "\n" + e);
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

    public string GetMostRecentlyUpdatedProfileId()
    { 
        string mostRecentProfileId = null;
        Dictionary<string, GameData> profilesGameData = LoadAllFiles();
        foreach (KeyValuePair<string, GameData> pair in profilesGameData)
        {
            string profileId = pair.Key;
            GameData gameData = pair.Value;
             
            // skip this entry if the gamedata is null  
            if(gameData == null)
            {
                continue;
            }

            //if this is the first data we've come across that exists, it's the most recent so far
            if(mostRecentProfileId == null)
            {
                mostRecentProfileId = profileId;
            }
            // otherwise, compare to see which date is the most recent
            else
            {
                DateTime mostRecentDateTime = DateTime.FromBinary(profilesGameData[mostRecentProfileId].lastUpdated);
                DateTime newDateTime = DateTime.FromBinary(gameData.lastUpdated);
                // the greatest DateTime value is the most recent
                if (newDateTime > mostRecentDateTime)
                {
                    mostRecentProfileId = profileId;
                }
            }
            
        }
         return mostRecentProfileId;
    }  
}
