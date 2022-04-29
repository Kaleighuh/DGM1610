using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerHealth")]
    public int curHP;
    public int maxHP;
    private HealthBar healthBar;

    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("Inventory")]
    public int key;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    [Header("Player Combat")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;


    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();

        healthBar = GetComponent<HealthBar>();
        curHP = maxHP;
        healthBar.SetHealth(maxHP);
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
    }

    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP);
        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player is dead...");
        Destroy(gameObject);
    }

}
