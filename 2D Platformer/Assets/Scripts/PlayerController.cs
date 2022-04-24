using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]

    public float speed;
    public float jumpHeight;
    private Rigidbody rb;

    [Header("GroundCheck")]

    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        //nonstickplayer
        moveVelocity = 0.0f;
        
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
         if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        //move player left and right
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
      
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight)
;    }
}
