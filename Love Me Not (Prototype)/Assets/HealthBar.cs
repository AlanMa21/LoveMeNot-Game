using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour, IDataPersistance
{
    public Slider healthSlider;
    public void SetSlider(float amount)
    {
        healthSlider.value = amount;

    }

    public void SetSliderMax(float amount)
    {
        healthSlider.maxValue = amount;
        SetSlider(amount);

    }

    public void SetSliderMin(float amount)
    {
         healthSlider.minValue = amount;
         SetSlider(amount);
    }

    public void LoadData(GameData data)
    {
       this.healthSlider.value = data.playerPoints;
       Debug.Log(data.playerPoints);
       SetSlider(data.playerPoints);
    }

    public void SaveData(ref GameData data)
    {
        data.playerPoints = this.healthSlider.value;
        Debug.Log(data.playerPoints);
    }

}
