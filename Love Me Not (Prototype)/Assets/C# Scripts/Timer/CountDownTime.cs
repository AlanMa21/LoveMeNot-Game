using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTime : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 20f;

    public GameObject failScene;

    [SerializeField] TextMeshProUGUI countdownTimer;

    void Start()
    {
        currentTime = startingTime;
        StartCoroutine(CountDownTimer());

    }
    

    public IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(1);

        currentTime -= 1;
        countdownTimer.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            failScene.SetActive(true);
        }
        else
        {
            StartCoroutine(CountDownTimer());
        }
    }
}
