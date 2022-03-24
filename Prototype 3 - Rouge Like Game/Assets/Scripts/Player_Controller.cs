using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    
    [Header ("Player Movement")]
    public float moveSpeed = 5f; // speed at which the player moves
    private Rigidbody2D rb; // Store the referenced 2D rigidbody

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
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Left and right movement
        movement.y = Input.GetAxis("Vertical"); // Up and down movement
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
            {
                Attack();
            }
        }
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
    // Set number of calls per fram
    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
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
        if(curHP <= 0)
        {
            Die();
        }
        
    }
     public void Die()
    {
        Debug.Log("Player has retired");
    }
}
