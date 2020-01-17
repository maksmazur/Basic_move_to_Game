using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Movesphere : MonoBehaviour

{
    public float playerSpeed;
    public float Jump;


    private bool isJumping;
    private float move;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

          if (CrossPlatformInputManager.GetButtonDown("Jump") && !isJumping)
          {
              rb.AddForce(new Vector2(rb.velocity.x, Jump));
              isJumping = true;
          }
        

       /* if (CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * 7000f);
        */

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }


    private void FixedUpdate()
    {
       
    }
}
