using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBreadMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    private float x;
    private float y;


    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
         x = Input.GetAxisRaw("Horizontal");
         y = Input.GetAxisRaw("Vertical");
    }
    

    // Update is called once per frame
    private void FixedUpdateUpdate()
    {
         if(NewDialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        rb.velocity = new Vector3(x * moveSpeed, y * moveSpeed);
        
        


    }
}
