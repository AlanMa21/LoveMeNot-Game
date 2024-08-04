using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreadMovement : MonoBehaviour, IDataPersistance
{
   
   public float moveSpeed = 1f;


   public float collisionOffset = 0.05f;
   public ContactFilter2D movementFilter; 

   public void LoadData(GameData data)
   {
      this.transform.position = data.playerPosition;
   }
   
   public void SaveGame(ref GameData data)
   {
      data.playerPosition = this.transform.position;
   }



   Vector2 movementInput;
   SpriteRenderer spriteRenderer;
   Rigidbody2D rb;
   Animator animator;

   List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

   public bool canMove;


    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if(NewDialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        

        if (canMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                SetDirection("dirIsUp");
                //Forward
                //animator.SetBool("dirIsUp", true);
            }
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                SetDirection("dirIsSide");
                //Sideways
                //animator.SetBool("dirIsSide", true);
            }
            
            if(Input.GetKey(KeyCode.S))
            {
                SetDirection("dirIsDown");
                //Back
                //animator.SetBool("dirIsDown", true);
            }




            if (movementInput != Vector2.zero)
            {
                bool success = TryMove(movementInput);

                if (!success)
                {
                    success = TryMove(new Vector2(movementInput.x, 0));

                }

                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }

                animator.SetBool("isMoving", success);
                
            }
            else
            {
                animator.SetBool("isMoving", false);
            }

            if (movementInput.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (movementInput.x > 0)
            {
                spriteRenderer.flipX = false;

            }

             if (movementInput.y < 0)
             {
                
             }
             
        } 




    }

    private bool TryMove(Vector2 direction){
        if(direction != Vector2.zero){

        }
          int count = rb.Cast(
                direction,
                movementFilter,
                castCollisions,
                moveSpeed * Time.fixedDeltaTime );

            if(count == 0){
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            

            } else
                {
                    return false;
                }

        
        
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }


    //void OnFire() {
       // animator.SetTrigger("swordAttack");
    //}

    void SetDirection(string dirName)
    {
        animator.SetBool("dirIsUp", false);
        animator.SetBool("dirIsSide", false);
        animator.SetBool("dirIsDown", false);

        animator.SetBool(dirName, true);
    }

    

   
}
