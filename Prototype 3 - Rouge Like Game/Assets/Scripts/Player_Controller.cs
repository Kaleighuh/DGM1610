using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;
    
    [Header ("Player Movement")]
    public float moveSpeed = 5f; // speed at which the player moves
    private Rigidbody2D rb; // Store the referenced 2D rigidbody

    [Header("Inventory")]
    public int key;
    public int gems;
    public int coins;

    Vector2 movement; //  Store the players x and y positions
    private Vector2 direction;

    [Header ("Player Combat")]
    public float attackRange; // range at which the player can attack
    public float attackRate; // the rate at which the player attacks
    private float lastAttackTime; // the timing of the last attack
    public int damage; // damage dealt to enemy
    public LayerMask enemyLayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Left and right movement
        movement.y = Input.GetAxis("Vertical"); // Up and down movement

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >= attackRate)
                Attack();
        }
    }

    // Set number of calls per fram
    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);
        if(vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;
    }
    void Attack()
    {
        lastAttackTime = Time.time; 
        // raycast using the enemy layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
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
     public void Die()
    {
        Debug.Log("Player has now passed away tragically");
    }
}
