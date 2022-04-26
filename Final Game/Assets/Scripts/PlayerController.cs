using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

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
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Ground check sensor
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        //Non-stick player
        moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        //Move playerleft and right
        rb.velocity = new Vector2(moveVelocity,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
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
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }
}
