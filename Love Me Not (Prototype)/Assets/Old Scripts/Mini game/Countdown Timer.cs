using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()    
    { 
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1  * Time.deltaTime;
        print(currentTime);
    }


}
