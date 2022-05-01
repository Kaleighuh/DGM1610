using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerHealth")]
    public int curHP;
    public int maxHP;

    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("Inventory")]
    public int health;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    [Header("Player Damage")]
    public int damage;
    private float lastAttackTime;
    public LayerMask enemyLayer;

    public int sceneToLoad;


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
        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player is dead...");
        Destroy(gameObject);
        EndGame();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
