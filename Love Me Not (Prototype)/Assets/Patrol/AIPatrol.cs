using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoints;
    public float speed;
    void Start()
    {
        targetPoints = 0;
    }

   
    void Update()
    {
        if(transform.position == patrolPoints[targetPoints].position)
        {
            increaseTargetInt();
        }
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[targetPoints].position, speed * Time.deltaTime);
    }

    void increaseTargetInt()
    {
        targetPoints++;
        if(targetPoints >= patrolPoints.Length)
        {
            targetPoints = 0;
        }
    }
}
