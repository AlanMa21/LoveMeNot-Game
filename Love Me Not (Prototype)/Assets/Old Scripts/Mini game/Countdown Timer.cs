using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    public GameObject failScene;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()    
    { 
        currentTime = startingTime;
        StartCoroutine(CountDownTimer());
    }

    void Update()
    {
        /*currentTime -= 1  * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            failScene.SetActive(true);
        }*/
    }

    public IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(1);
        
        currentTime -= 1;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            failScene.SetActive(true);
            StopCoroutine(CountDownTimer());
        }
        else
        {
            StartCoroutine(CountDownTimer());
        }
        
        
    }


}
