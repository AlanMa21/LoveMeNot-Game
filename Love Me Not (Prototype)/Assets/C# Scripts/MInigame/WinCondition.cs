using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

public class WinCondition : MonoBehaviour
{
    public CountDownTime timer;
    public Coin coin;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            if(GameManager.MyInstance.collectedCoins == 3)
            {
                timer.StopAllCoroutines();
            }
            GameManager.MyInstance.Finish();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            UIManager.MyInstance.HideVictoryCondition();
        }
    }
}
