using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChas : MonoBehaviour
{

    public GameObject player;
    public float speed;

    public float distanceBetween;

    private float distance;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;


       
        if(distance < distanceBetween)
        {
              transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
             

        }

      


    }
}
