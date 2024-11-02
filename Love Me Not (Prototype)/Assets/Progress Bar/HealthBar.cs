using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour, IDataPersistance
{
    public Slider healthSlider;
    public void SetSlider(float amount)
    {
        healthSlider.value = amount;

    }
    public void Awake()
    {
        DataPersistanceManager.instance.healthBar = this;
        healthSlider.value = DataPersistanceManager.instance.gameData.healthSlider;
        DataPersistanceManager.instance.dataPersistanceObjects.Add(this);
    }
    public void SetSliderMax(float amount)
    {
        healthSlider.maxValue = amount;
        SetSlider(amount);

    }
    public void OnSceneLoaded()
    {
        healthSlider.value = DataPersistanceManager.instance.gameData.healthSlider;
    }

    public void SetSliderMin(float amount)
    {
         healthSlider.minValue = amount;
         SetSlider(amount);
    }

    public void LoadData(GameData data)
    {
      this.healthSlider.value = DataPersistanceManager.instance.gameData.healthSlider;
      Debug.Log(data.healthSlider);
    }

    public void SaveData(GameData data)
    {
        Debug.Log(data.healthSlider);
        DataPersistanceManager.instance.gameData.healthSlider = this.healthSlider.value;
        
    }

}
